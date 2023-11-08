IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_UPD_FERIAS')
	DROP PROCEDURE dbo.SP_UPD_FERIAS
GO

CREATE PROCEDURE dbo.SP_UPD_FERIAS
	@inicioFerias DATETIME,
	@id INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN		
		DECLARE
		@dataAdmin datetime,
		@fimferiasatual datetime

	DECLARE
	@inicioFeriasTratado DATETIME SET @inicioFeriasTratado = CONVERT(DATE, @inicioFerias, 103)


		select @dataAdmin = dataAdmissao, @fimferiasatual = fimFerias FROM dbo.Funcionarios where idFuncionario = @id 
			IF (
			DATEDIFF(YEAR, @dataAdmin, GETDATE()) >= 1
			AND (
			@fimferiasatual IS NULL
			OR DATEDIFF(YEAR, @dataAdmin, @fimferiasatual) < 1
			)
			  )
			BEGIN
			UPDATE Funcionarios set inicioFerias = @inicioFeriasTratado, fimFerias = DATEADD(MONTH,1,@inicioFerias) where idfuncionario = @id
			END

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN	
		DECLARE	@ErrorMessage NVARCHAR(4000), @ErrorSeverity INT, @ErrorState INT;
		SELECT @ErrorMessage = ERROR_MESSAGE(), @ErrorSeverity = ERROR_SEVERITY(), @ErrorState = ERROR_STATE();
		RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
	END CATCH
END 
GO