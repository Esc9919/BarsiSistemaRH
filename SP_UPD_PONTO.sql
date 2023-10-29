IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_UPD_PONTO')
	DROP PROCEDURE dbo.SP_UPD_PONTO
GO

CREATE PROCEDURE dbo.SP_UPD_PONTO
	@ID_FUNCIONARIO INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN			
			IF NOT EXISTS (SELECT pontoEntrada FROM dbo.Pontos WITH(NOLOCK)
						WHERE idFuncionario = @ID_FUNCIONARIO AND
						CAST(pontoEntrada AS DATE) = CAST(GETDATE() as date))
				BEGIN 
					INSERT INTO
						dbo.Pontos
						(idFuncionario, pontoEntrada)
					VALUES
						(1, GETDATE())
				END				
				
				DECLARE @MINUTO_INICIO_JORNADA INT = (SELECT DATEDIFF(MINUTE, pontoEntrada, GETDATE()) FROM [dbo].[Pontos] WITH(NOLOCK)
										WHERE idFuncionario = @ID_FUNCIONARIO AND
										CAST(pontoEntrada as date) = CAST(GETDATE() as date) AND
										pontoAlmocoSaida IS NULL)
				IF (@MINUTO_INICIO_JORNADA >= 6)
				BEGIN
					UPDATE dbo.Pontos
					SET pontoAlmocoSaida = GETDATE()					
					WHERE idFuncionario = @ID_FUNCIONARIO AND
						CAST(pontoEntrada AS DATE) = CAST(GETDATE() AS DATE) AND
						pontoAlmocoSaida IS NULL

					DECLARE @QTDE_PARCIAL_INICIAL TIME = (SELECT CONVERT(TIME, pontoAlmocoSaida - pontoEntrada) FROM [dbo].[Pontos] WITH(NOLOCK)
										WHERE idFuncionario = @ID_FUNCIONARIO AND
										CAST(pontoEntrada as date) = CAST(GETDATE() as date) AND
										CAST(pontoAlmocoSaida as date) = CAST(GETDATE() as date))
					UPDATE dbo.Pontos
					SET pontoAlmocoSaida = GETDATE(),
					horasTrabalhadas = @QTDE_PARCIAL_INICIAL
					WHERE idFuncionario = @ID_FUNCIONARIO AND
						CAST(pontoEntrada AS DATE) = CAST(GETDATE() AS DATE) AND
						CAST(pontoAlmocoSaida as date) = CAST(GETDATE() as date)
				END
				
				DECLARE @MINUTO_TERMINO_ALMOCO INT = (SELECT DATEDIFF(MINUTE, pontoAlmocoSaida, GETDATE()) FROM [dbo].[Pontos] WITH(NOLOCK)
										WHERE idFuncionario = @ID_FUNCIONARIO AND
										CAST(pontoEntrada AS DATE) = CAST(GETDATE() AS DATE) AND
										CAST(pontoAlmocoSaida AS DATE) = CAST(GETDATE() AS DATE) AND
										pontoAlmocoVolta IS NULL)
				IF (@MINUTO_TERMINO_ALMOCO >= 6)
				BEGIN
					UPDATE dbo.Pontos
					SET pontoAlmocoVolta = GETDATE()					
					WHERE idFuncionario = @ID_FUNCIONARIO AND
						CAST(pontoEntrada AS DATE) = CAST(GETDATE() AS DATE) AND
						CAST(pontoAlmocoSaida AS DATE) = CAST(GETDATE() AS DATE) AND
						pontoAlmocoVolta	IS NULL					
				END
				
				DECLARE @MINUTO_TERMINO_JORNADA INT = (SELECT DATEDIFF(MINUTE, pontoAlmocoVolta, GETDATE()) FROM [dbo].[Pontos] WITH(NOLOCK)
										WHERE idFuncionario = @ID_FUNCIONARIO AND
										CAST(pontoEntrada AS DATE) = CAST(GETDATE() AS DATE) AND
										CAST(pontoAlmocoSaida AS DATE) = CAST(GETDATE() AS DATE) AND
										CAST(pontoAlmocoVolta AS DATE) = CAST(GETDATE() AS DATE) AND
										pontoSaida	IS NULL)
				IF (@MINUTO_TERMINO_JORNADA >= 6)
				BEGIN				
					UPDATE dbo.Pontos
					SET pontoSaida = GETDATE()					
					WHERE idFuncionario = @ID_FUNCIONARIO AND
						Cast(pontoEntrada as date) = Cast(Getdate() as date) AND
						Cast(pontoAlmocoSaida as date) = Cast(Getdate() as date) AND
						Cast(pontoAlmocoVolta as date) = Cast(Getdate() as date) AND
						pontoSaida	IS  NULL

					DECLARE @QTDE_PARCIAL_FINAL TIME = (SELECT CONVERT(TIME, pontoSaida - pontoEntrada) FROM [dbo].[Pontos] WITH(NOLOCK)
									WHERE idFuncionario = @ID_FUNCIONARIO AND
									Cast(pontoEntrada as date) = Cast(Getdate() as date) AND
									Cast(pontoAlmocoSaida as date) = Cast(Getdate() as date) AND
									Cast(pontoAlmocoVolta as date) = Cast(Getdate() as date) AND
									Cast(pontoSaida as date) = Cast(Getdate() as date))
					UPDATE dbo.Pontos
					SET pontoSaida = GETDATE(),
					horasTrabalhadas = @QTDE_PARCIAL_FINAL
					WHERE idFuncionario = @ID_FUNCIONARIO AND
						Cast(pontoEntrada as date) = Cast(Getdate() as date) AND
						Cast(pontoAlmocoSaida as date) = Cast(Getdate() as date) AND
						Cast(pontoAlmocoVolta as date) = Cast(Getdate() as date) AND
						Cast(pontoSaida as date) = Cast(Getdate() as date)

				END

				DECLARE @PONTO_EXTRA1 INT = (SELECT DATEDIFF(MINUTE, pontoSaida, GETDATE()) FROM [dbo].[Pontos] WITH(NOLOCK)
										WHERE idFuncionario = @ID_FUNCIONARIO AND
										CAST(pontoEntrada AS DATE) = CAST(GETDATE() AS DATE) AND
										CAST(pontoAlmocoSaida AS DATE) = CAST(GETDATE() AS DATE) AND
										CAST(pontoAlmocoVolta AS DATE) = CAST(GETDATE() AS DATE) AND
										CAST(pontoSaida AS DATE) = CAST(GETDATE() AS DATE) AND
										pontoExtra1	IS NULL)
				IF (@PONTO_EXTRA1 >= 6)
				BEGIN				
					UPDATE dbo.Pontos
					SET pontoExtra1 = GETDATE()					
					WHERE idFuncionario = @ID_FUNCIONARIO AND
										CAST(pontoEntrada AS DATE) = CAST(GETDATE() AS DATE) AND
										CAST(pontoAlmocoSaida AS DATE) = CAST(GETDATE() AS DATE) AND
										CAST(pontoAlmocoVolta AS DATE) = CAST(GETDATE() AS DATE) AND
										CAST(pontoSaida AS DATE) = CAST(GETDATE() AS DATE) AND
										pontoExtra1	IS NULL				
				END




				DECLARE @EXTRA2 INT = (SELECT DATEDIFF(MINUTE, pontoExtra1, GETDATE()) FROM [dbo].[Pontos] WITH(NOLOCK)
										WHERE idFuncionario = @ID_FUNCIONARIO AND
										CAST(pontoEntrada AS DATE) = CAST(GETDATE() AS DATE) AND
										CAST(pontoAlmocoSaida AS DATE) = CAST(GETDATE() AS DATE) AND
										CAST(pontoAlmocoVolta AS DATE) = CAST(GETDATE() AS DATE) AND
										CAST(pontoSaida AS DATE) = CAST(GETDATE() AS DATE) AND
										CAST(pontoExtra1 AS DATE) = CAST(GETDATE() AS DATE) AND
										pontoExtra2	IS NULL)
				IF (@MINUTO_TERMINO_JORNADA >= 6)
				BEGIN				
					UPDATE dbo.Pontos
					SET pontoExtra2 = GETDATE()					
					WHERE idFuncionario = @ID_FUNCIONARIO AND
										CAST(pontoEntrada AS DATE) = CAST(GETDATE() AS DATE) AND
										CAST(pontoAlmocoSaida AS DATE) = CAST(GETDATE() AS DATE) AND
										CAST(pontoAlmocoVolta AS DATE) = CAST(GETDATE() AS DATE) AND
										CAST(pontoSaida AS DATE) = CAST(GETDATE() AS DATE) AND
										CAST(pontoExtra1 AS DATE) = CAST(GETDATE() AS DATE) AND
										pontoExtra2	IS NULL

					DECLARE @QTDE_PARCIAL_FINAL_EXTRA TIME = (SELECT CONVERT(TIME, pontoExtra2 - pontoEntrada) FROM [dbo].[Pontos] WITH(NOLOCK)
									WHERE idFuncionario = @ID_FUNCIONARIO AND
										CAST(pontoEntrada AS DATE) = CAST(GETDATE() AS DATE) AND
										CAST(pontoAlmocoSaida AS DATE) = CAST(GETDATE() AS DATE) AND
										CAST(pontoAlmocoVolta AS DATE) = CAST(GETDATE() AS DATE) AND
										CAST(pontoSaida AS DATE) = CAST(GETDATE() AS DATE) AND
										CAST(pontoExtra1 AS DATE) = CAST(GETDATE() AS DATE) AND
										CAST(pontoExtra2 AS DATE) = CAST(GETDATE() AS DATE))
					UPDATE dbo.Pontos
					SET pontoExtra2 = GETDATE(),
					horasTrabalhadas = @QTDE_PARCIAL_FINAL_EXTRA
					WHERE idFuncionario = @ID_FUNCIONARIO AND
										CAST(pontoEntrada AS DATE) = CAST(GETDATE() AS DATE) AND
										CAST(pontoAlmocoSaida AS DATE) = CAST(GETDATE() AS DATE) AND
										CAST(pontoAlmocoVolta AS DATE) = CAST(GETDATE() AS DATE) AND
										CAST(pontoSaida AS DATE) = CAST(GETDATE() AS DATE) AND
										CAST(pontoExtra1 AS DATE) = CAST(GETDATE() AS DATE) AND
										CAST(pontoExtra2 AS DATE) = CAST(GETDATE() AS DATE)

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