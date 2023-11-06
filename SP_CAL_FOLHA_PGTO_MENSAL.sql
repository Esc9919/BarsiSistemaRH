IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_CAL_FOLHA_PGTO_MENSAL')
	DROP PROCEDURE dbo.SP_CAL_FOLHA_PGTO_MENSAL
GO
CREATE PROCEDURE SP_CAL_FOLHA_PGTO_MENSAL
@ID_FUNCIONARIO INT,
@DATA_INICIAL DATE,
@DATA_FINAL DATE
AS
BEGIN
  BEGIN TRY

 IF ISNULL(OBJECT_ID('TEMPDB..#FolhaDePagamento'),0)<> 0 
	BEGIN
		DROP TABLE #FolhaDePagamento
	END
 IF ISNULL(OBJECT_ID('TEMPDB..#TEMPO_TRABALHADO'),0)<> 0 
	BEGIN
		DROP TABLE #TEMPO_TRABALHADO
	END
 IF ISNULL(OBJECT_ID('TEMPDB..#TEMPO_TRATADO'),0)<> 0 
	BEGIN
		DROP TABLE #TEMPO_TRATADO
	END

    CREATE TABLE #FolhaDePagamento (
        FuncionarioID INT,
        Nome VARCHAR(100),
        SalarioBase DECIMAL(10, 2),
        HorasTrabalhadas DECIMAL(10, 2),
		HorasExtras DECIMAL (10,2),
		TempoExatoTrabalhado DECIMAL,
		TempoExtraExatoTrabalhado DECIMAL,
        TotalSalario DECIMAL(10, 2),
		INSS DECIMAL (10,2),
		IRPF DECIMAL (10,2),
		SalarioLiquido DECIMAL (10,2)
    )

	
	DECLARE
	@DATA_INICIAL_CONVERTIDA DATE SET @DATA_INICIAL_CONVERTIDA = CONVERT(DATE, @DATA_INICIAL, 103)

	DECLARE
	@DATA_FINAL_CONVERTIDA DATE SET @DATA_FINAL_CONVERTIDA = CONVERT(DATE, @DATA_FINAL, 103)

	select  SUM(DATEDIFF(minute, '00:00:00', horasTrabalhadas)) as MINUTOS 
		INTO #TEMPO_TRABALHADO 
			From pontos 
			WHERE pontoEntrada BETWEEN @DATA_INICIAL_CONVERTIDA 
			AND @DATA_FINAL_CONVERTIDA 
			AND idFuncionario = @ID_FUNCIONARIO

	SELECT MINUTOS_TRABALHADOS = CASE WHEN MINUTOS >= 9600 THEN '9600' ELSE MINUTOS END,
	MINUTOS_EXTRAS = CASE WHEN MINUTOS > 9600 THEN MINUTOS - 9600 ELSE 0 END INTO
	#TEMPO_TRATADO FROM #TEMPO_TRABALHADO 

    
    INSERT INTO #FolhaDePagamento (FuncionarioID, Nome, SalarioBase, HorasTrabalhadas,HorasExtras,TempoExatoTrabalhado,TempoExtraExatoTrabalhado)
    SELECT FuncionarioID = Funcionarios.IDFUNCIONARIO,
	Nome = Funcionarios.nome,
	SalarioBase = Funcionarios.salario,
	HorasTrabalhadas = (SELECT MINUTOS_TRABALHADOS/60 FROM #TEMPO_TRATADO),
	HorasExtras = (SELECT MINUTOS_EXTRAS/60 FROM #TEMPO_TRATADO),
	TempoExatoTrabalhado = (SELECT MINUTOS_TRABALHADOS FROM #TEMPO_TRATADO),
	TempoExtraExatoTrabalhado = (SELECT MINUTOS_EXTRAS FROM #TEMPO_TRATADO)
	FROM Funcionarios INNER JOIN
	Pontos on
	funcionarios.idFuncionario = Pontos.idFuncionario
	WHERE Funcionarios.idFuncionario = @ID_FUNCIONARIO

    UPDATE #FolhaDePagamento
    SET TotalSalario = ((SalarioBase/9600) * TempoExatoTrabalhado) + ((SalarioBase/9600 * 1.70) * TempoExtraExatoTrabalhado)


    UPDATE #FolhaDePagamento
    SET INSS = CASE WHEN TotalSalario < 1320.00 THEN (TotalSalario * 0.075)
			   WHEN TotalSalario > 1320.00 AND TotalSalario <= 2571.29 THEN (TotalSalario * 0.09)
			   WHEN TotalSalario > 2571.29 AND TotalSalario <= 3856.94 THEN (TotalSalario * 0.12)
			   WHEN (TotalSalario * 0.14) > 1501.50 THEN 1501.50 END
		
		
		UPDATE A
    SET A.IRPF = CASE WHEN (A.TotalSalario - A.INSS) < 2112.00 THEN 0.00
			   WHEN (A.TotalSalario - A.INSS ) <= 2826.65 AND (A.TotalSalario - A.INSS) > 2112.00  THEN CASE WHEN (((A.TotalSalario - A.INSS)*0.075) - (isnull(B.Dependentes,0) * 189.59)) - 158.40 < 0 
			   THEN 0.00 
			   ELSE (((A.TotalSalario - A.INSS)*0.075) - (isnull(B.Dependentes,0) * 189.59)) - 158.40 END
			   WHEN (A.TotalSalario - A.INSS ) <= 3751.05 AND (A.TotalSalario - A.INSS) > 2826.65  THEN CASE WHEN (((A.TotalSalario - A.INSS)*0.15) - (isnull(B.Dependentes,0) * 189.59)) - 370.40 < 0
			   THEN 0.00 
			   ELSE (((A.TotalSalario - A.INSS)*0.15) - (isnull(B.Dependentes,0) * 189.59)) - 370.40 END 
			   WHEN (A.TotalSalario - A.INSS ) <= 4667.68 AND (A.TotalSalario - A.INSS) > 3751.05  THEN CASE WHEN (((A.TotalSalario - A.INSS)*0.225) - (isnull(B.Dependentes,0) * 189.59)) - 651.73 < 0
			   THEN 0.00 
			   ELSE (((A.TotalSalario - A.INSS)*0.225) - (isnull(B.Dependentes,0) * 189.59)) - 651.73 END 
			   ELSE CASE WHEN (((A.TotalSalario - A.INSS)*0.275) - (isnull(B.Dependentes,0) * 189.59)) - 884.96 < 0
			   THEN 0.00 
			   ELSE (((A.TotalSalario - A.INSS)*0.275) - (isnull(B.Dependentes,0) * 189.59)) - 884.96 END END
			   from #FolhaDePagamento A inner join
			   Funcionarios B ON
			   A.FuncionarioID = B.idFuncionario


	UPDATE #FolhaDePagamento
	SET SalarioLiquido = TotalSalario - INSS - IRPF


    
    SELECT DISTINCT * FROM #FolhaDePagamento

END TRY

BEGIN CATCH
		ROLLBACK TRAN	
		DECLARE	@ErrorMessage NVARCHAR(4000), @ErrorSeverity INT, @ErrorState INT;
		SELECT @ErrorMessage = ERROR_MESSAGE(), @ErrorSeverity = ERROR_SEVERITY(), @ErrorState = ERROR_STATE();
		RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
	END CATCH
END