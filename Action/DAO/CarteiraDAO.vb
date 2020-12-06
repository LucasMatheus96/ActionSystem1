Imports System.Data.Common
Imports Action.Conexao
Imports System.Data.SqlClient
Imports Action.classes

Namespace DAO
    Public Class CarteiraDAO

        Shared Function DBConsultarCarteira() As DataTable

            Try

                Dim conexaoBD As New ConexaoBD

                Dim Dt As New DataTable
                Dim Ds As New DataSet

                conexaoBD.strInstrucao = "SpSel_ConsultaCarteira"
                conexaoBD.objCommand.CommandType = CommandType.StoredProcedure
                conexaoBD.objCommand.CommandText = conexaoBD.strInstrucao
                conexaoBD.objCommand.Connection = conexaoBD.objConexao



                Dim Da As New SqlDataAdapter(conexaoBD.objCommand)
                Da.Fill(Ds)
                Dt = Ds.Tables(0)
                conexaoBD.objConexao.Close()

                Return Dt

            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try
        End Function


        Shared Function DbPesquisaNomeCarteira(Nome As String) As DataTable

            Try

                Dim conexaoBD As New ConexaoBD

                Dim Dt As New DataTable
                Dim Ds As New DataSet

                conexaoBD.strInstrucao = "SELECT * FROM tabCarteira 
                                          INNER JOIN tabUsuario ON TabCarteira.IOperador = tabUsuario.id   
                                          where nomecarteira like '%" + Nome + "%'"
                conexaoBD.objCommand.Parameters.AddWithValue("@nome", Nome)
                conexaoBD.objCommand.CommandType = CommandType.Text
                conexaoBD.objCommand.CommandText = conexaoBD.strInstrucao
                conexaoBD.objCommand.Connection = conexaoBD.objConexao



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
                ConexaoBD.objCommand.Parameters.AddWithValue("@ioperador", Carteira.Operador)
                'ConexaoBD.objCommand.Parameters.AddWithValue("@iOperador")

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
                ConexaoBD.objCommand.Parameters.AddWithValue("@ID", Carteira.Id)
                ConexaoBD.objCommand.Parameters.AddWithValue("@NomeCarteira", Carteira.NomeCarteira)

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

                ConexaoBD.objCommand.ExecuteNonQuery()
                ConexaoBD.objConexao.Close()

            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try
        End Sub

        Shared Function DbPesquisaCarteiraPorData(dataInicial As Date, dataFinal As Date) As DataTable

            Try

                Dim conexaoBD As New ConexaoBD

                Dim Dt As New DataTable
                Dim Ds As New DataSet

                conexaoBD.strInstrucao = "SELECT * FROM tabCarteira 
                                          INNER JOIN tabUsuario ON TabCarteira.IOperador = tabUsuario.id   
                                          where dataTransacao between '" + dataInicial + "'" + "And" + "'" + dataFinal + "'"
                conexaoBD.objCommand.Parameters.AddWithValue("@dataInicial", dataInicial)
                conexaoBD.objCommand.Parameters.AddWithValue("@dataFinal", dataFinal)
                conexaoBD.objCommand.CommandType = CommandType.Text
                conexaoBD.objCommand.CommandText = conexaoBD.strInstrucao
                conexaoBD.objCommand.Connection = conexaoBD.objConexao



                Dim Da As New SqlDataAdapter(conexaoBD.objCommand)
                Da.Fill(Ds)
                Dt = Ds.Tables(0)
                conexaoBD.objConexao.Close()

                Return Dt

            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try
        End Function



    End Class
End Namespace

