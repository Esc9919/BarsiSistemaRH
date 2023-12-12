﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Barsi.Web.Login" %>

<!DOCTYPE html>
<html lang="pt-br">
  <head>
    <!-- Meta tags Obrigatórias -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    <link rel="stylesheet" href="bootstrap-5.3.1-dist">

     <!--CSS-->
    <link rel="stylesheet" href="./css/style.css">

    <!--Font awesome-->
    <link rel="stylesheet" type="text/css" href="fontawesome/css/all.min.css">
    <!--icone do navegador-->
    <link rel="icon" type="image/x-icon" href="./imagens/logoBarsi-B.png">


    <title>Barsi Investimentos | Login</title>
  </head>
  <body class="tela-login bg-primary">

      <form id="form1" runat="server">

    <header><!-- inicio cabeçalho -->
       <div class="row flex-nowrap">
        <nav class="bg-dark col-md-12">
                <a href="#" class="navbar-brand d-flex align-item-center">
                    <img src="imagens/logoBarsi.png" class="offset-md-5" width="250px">
                </a>
        </nav>
    </div> 
    </header><!--fim cabeçalho-->

    <section id="formulario-login bg-primary"><!--inicio formulário login-->
       
        <div class="row flex-nowrap">
            <div class="col-md-12 ">
                <div class="form-group card mt-5 pt-2 pb-5 col-md-4 offset-md-4">

                        <span class="offset-md-3" id="bem-vindo">Bem-vindo a Barsi!</span>
                        



                    <div class="centered-container">
                            <div class="col-md-12 mt-2 mb-2">
                                <label for="login">Login<asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                                </label>&nbsp;
                            </div>
                            <div class="col-md-12 mt-2 mb-2">
                                <label for="senha">Senha<asp:TextBox ID="txtSenha" runat="server" TextMode="Password" style="margin-top: 5px;"></asp:TextBox>
                                </label>&nbsp;&nbsp;
                            </div>
                    </div>

                        <button class="btn btn-primary col-md-6 offset-md-3 p-3 mt-5" id="btn-entrar">
                            <label for="senha">
                            <asp:Button ID="Button1" runat="server" ForeColor="#0066FF" OnClick="Button1_Click1" Text="ENTRAR" ViewStateMode="Enabled" />
                            </label>
                        </button>

                </div>
            </div>
        </div>

    </section><!--fim formulário login-->

    <!-- JavaScript (Opcional) -->
    <!-- jQuery primeiro, depois Popper.js, depois Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
      </form>
  </body>
</html>