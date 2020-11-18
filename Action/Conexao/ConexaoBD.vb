﻿Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Security.Policy
Imports Action.classes

Imports Action.classes.hash
Imports System.Security.Cryptography
Imports System.Reflection

Namespace Conexao


    Public Class ConexaoBD

        Dim Hash As New Criptografia(SHA512.Create())
        Dim hashTxtSenha As String = ""


        Public Const strConexao As String = "Data Source=DESKTOP-ISMFG00;Initial Catalog=dbAction;Integrated Security=True"
        'Variável que receberá a Instrução SQL, que será passada de acordo com o método usado
        Public strInstrucao As String = String.Empty
        'Objeto instanciado da classe SqlConnection, com a string de conexão como parâmetro
        Public objConexao As New SqlConnection(strConexao)
        'Objeto instanciado da classe SqlCommand, com a instrução SQL e o objeto de conexão como parâmetro
        Public objCommand As New SqlCommand(strInstrucao, objConexao)



    End Class

End Namespace
