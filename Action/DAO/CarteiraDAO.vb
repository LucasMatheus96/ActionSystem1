Imports System.Data.Common
Imports Action.Conexao
Imports System.Data.SqlClient
Imports Action.classes

Namespace Dao
    Public Class CarteiraDAO

        Shared Function DbConsultarUsuario() As DataTable

            Try

                Dim conexaoBD As New ConexaoBD

                Dim Dt As New DataTable
                Dim Ds As New DataSet

                conexaoBD.strInstrucao = "SpSel_ConsultaCarteira"
                conexaoBD.objCommand.CommandType = CommandType.StoredProcedure
                conexaoBD.objCommand.CommandText = conexaoBD.strInstrucao
                conexaoBD.objCommand.Connection = conexaoBD.objConexao

                conexaoBD.objConexao.Open()

                Dim Da As New SqlDataAdapter(conexaoBD.objCommand)
                Da.Fill(Ds)
                Dt = Ds.Tables(0)
                conexaoBD.objConexao.Close()

                Return Dt

            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try
        End Function



        Shared Sub DBCadastrarCarteira(Carteira As Carteira)
            Try
                Dim ConexaoBD As New ConexaoBD()

                ConexaoBD.objCommand.CommandText = "SpIns_CadastraCarteira"
                ConexaoBD.objCommand.CommandType = CommandType.StoredProcedure
                ConexaoBD.objCommand.Parameters.AddWithValue("@NomeCarteira", Carteira.NomeCarteira)
                ConexaoBD.objCommand.Parameters.AddWithValue("@DataTransacao", Carteira.DataCadastro)
                ConexaoBD.objCommand.Parameters.AddWithValue("@ioperador", Carteira.operador)
                'ConexaoBD.objCommand.Parameters.AddWithValue("@iOperador")
                ConexaoBD.objConexao.Open()
                ConexaoBD.objCommand.ExecuteNonQuery()
                ConexaoBD.objConexao.Close()

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Sub
        Shared Sub DBAtualizaCarteira(ByVal Carteira As Carteira)

            Try
                Dim ConexaoBD As New ConexaoBD

                ConexaoBD.objCommand.CommandText = "SpUpd_AtualizaCarteira"
                ConexaoBD.objCommand.CommandType = CommandType.StoredProcedure
                ConexaoBD.objCommand.Parameters.AddWithValue("@ID", Carteira.ID)
                ConexaoBD.objCommand.Parameters.AddWithValue("@NomeCarteira", Carteira.NomeCarteira)
                ConexaoBD.objConexao.Open()
                ConexaoBD.objCommand.ExecuteNonQuery()
                ConexaoBD.objConexao.Close()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Sub

        Shared Sub DBExcluirCarteira(IdCliente As Integer, Optional NomeCarteira As String = "")

            Try
                Dim ConexaoBD As New ConexaoBD

                ConexaoBD.objCommand.CommandText = "SpDel_DeletaCarteira"
                ConexaoBD.objCommand.CommandType = CommandType.StoredProcedure
                ConexaoBD.objCommand.Parameters.AddWithValue("@ID", IdCliente)
                ConexaoBD.objCommand.Parameters.AddWithValue("@NomeCarteira", NomeCarteira)
                ConexaoBD.objConexao.Open()
                ConexaoBD.objCommand.ExecuteNonQuery()
                ConexaoBD.objConexao.Close()

            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try

        End Sub
    End Class
End Namespace

