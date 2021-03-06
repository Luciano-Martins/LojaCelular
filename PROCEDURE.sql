USE [DupCel_new]
GO
/****** Object:  StoredProcedure [dbo].[uspUsuarioInserir]    Script Date: 10/06/2022 11:35:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[uspUsuarioInserir]
	@Usuario  as varchar (100),
	@Senha as varchar (100)
	


AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
				
		 IF (EXISTS(SELECT Codigo 
		 FROM tblUsuario 
		 WHERE Usuario = @Usuario 
			))
		RAISERROR ('USUARIO JÁ CADASTRADO', 14,1)
				
		INSERT INTO tblUsuario(Usuario , Senha )
		VALUES (@Usuario,@Senha)

		SELECT @@IDENTITY AS Retorno;

		COMMIT TRAN
	END TRY
	BEGIN CATCH
	 ROLLBACK TRAN

	 SELECT ERROR_MESSAGE() AS Retorno;

	END CATCH

END
GO
/****** Object:  StoredProcedure [dbo].[uspUsuarioSenhaInserir]    Script Date: 10/06/2022 11:35:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[uspUsuarioSenhaInserir]
	@Usuario  as varchar (100),
	@Senha as varchar (100)
	


AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
				
		 IF (EXISTS(SELECT Codigo 
		 FROM tblUsuario 
		 WHERE Usuario = @Usuario 
			))
		RAISERROR ('USUARIO JÁ CADASTRADO', 14,1)
				
		INSERT INTO tblUsuario(Usuario , Senha )
		VALUES (@Usuario,@Senha)

		select convert(varchar(50),(20));

		COMMIT TRAN
	END TRY
	BEGIN CATCH
	 ROLLBACK TRAN

	 SELECT ERROR_MESSAGE() AS Retorno;

	END CATCH

END
GO
