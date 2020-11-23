Imports System.Data.SqlClient
Imports Action.classes
Imports Action.Conexao

Namespace DAO
    Public Class FundoImobiliarioDAO

        Shared Sub CadastrarFundoImobiliario(objFundoImobiliario As FundoImobiliario)

            Try
                Dim conexaoBD As New ConexaoBD

                conexaoBD.objCommand.CommandType = CommandType.StoredProcedure
                conexaoBD.objCommand.CommandText = "SpIns_CadastraFundoImobiliario"
                conexaoBD.objCommand.Parameters.AddWithValue("@NomeAtivo", objFundoImobiliario.NomeAtivo)
                conexaoBD.objCommand.Parameters.AddWithValue("@SiglaAtivo", objFundoImobiliario.SiglaAtivo)
                conexaoBD.objCommand.Parameters.AddWithValue("@IdTipoFundoImobiliario", objFundoImobiliario.IdTipoFundoImobiliario)

                conexaoBD.objCommand.ExecuteNonQuery()
                conexaoBD.objConexao.Close()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Shared Sub AlterarFundoImobiliario(objFundoImobiliario As FundoImobiliario)
            Try

                Dim conexaoBD As New ConexaoBD

                conexaoBD.objCommand.CommandType = CommandType.StoredProcedure
                conexaoBD.strInstrucao = "SpUpd_AlteraFundoImobiliario"
                conexaoBD.objCommand.CommandText = conexaoBD.strInstrucao
                conexaoBD.objCommand.Parameters.AddWithValue("@ID", objFundoImobiliario.ID)
                conexaoBD.objCommand.Parameters.AddWithValue("@NomeAtivo", objFundoImobiliario.NomeAtivo)
                conexaoBD.objCommand.Parameters.AddWithValue("@SiglaAtivo", objFundoImobiliario.SiglaAtivo)
                conexaoBD.objCommand.Parameters.AddWithValue("@IdTipoFundoImobiliario", objFundoImobiliario.IdTipoFundoImobiliario)
                conexaoBD.objCommand.ExecuteNonQuery()
                conexaoBD.objConexao.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Shared Function ConsultarFundoImobiliario() As DataTable

            Try
                Dim conexaoBD As New ConexaoBD
                Dim Dt As New DataTable
                Dim Ds As New DataSet

                conexaoBD.objCommand.CommandType = CommandType.StoredProcedure
                conexaoBD.strInstrucao = "SpSel_ConsultaFundoImobiliario"
                conexaoBD.objCommand.CommandText = conexaoBD.strInstrucao
                conexaoBD.objCommand.ExecuteNonQuery()

                Dim Da As New SqlDataAdapter(conexaoBD.objCommand)
                Da.Fill(Ds)
                Dt = Ds.Tables(0)
                conexaoBD.objConexao.Close()

                Return Dt

            Catch ex As Exception
                Throw ex
            End Try

        End Function

        Shared Sub ExcluirFundoImobiliario(IDFundoImobiliario As Integer)

            Try
                Dim ConexaoBD As New ConexaoBD

                ConexaoBD.objCommand.CommandType = CommandType.StoredProcedure
                ConexaoBD.strInstrucao = "spDel_DeletaFundoImobiliario"
                ConexaoBD.objCommand.CommandText = ConexaoBD.strInstrucao
                ConexaoBD.objCommand.Parameters.AddWithValue("@ID", IDFundoImobiliario)
                ConexaoBD.objCommand.ExecuteNonQuery()
                ConexaoBD.objConexao.Close()

            Catch ex As Exception

                Throw ex
            End Try



        End Sub

        Shared Function ConsultarTipoFundoImobiliario() As DataTable

            Try
                Dim ConexaoBD As New ConexaoBD

                Dim Dt As New DataTable
                Dim Ds As New DataSet

                ConexaoBD.objCommand.CommandType = CommandType.Text
                ConexaoBD.objCommand.CommandText = "SELECT * FROM tabTipoFundoImobiliario"

                ConexaoBD.objCommand.ExecuteNonQuery()

                Dim Da As New SqlDataAdapter(ConexaoBD.objCommand)
                Da.Fill(Ds)
                Dt = Ds.Tables(0)
                ConexaoBD.objConexao.Close()

                Return Dt

            Catch ex As Exception

                Throw New Exception(ex.Message)

            End Try
        End Function

    End Class
End Namespace


