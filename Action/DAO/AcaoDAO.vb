Imports System.Data.SqlClient
Imports Action.classes
Imports Action.Conexao

Namespace DAO

    Public Class AcaoDAO


        Shared Sub CadastrarAcao(objAcao As Acao)

            Try
                Dim conexaoBD As New ConexaoBD

                conexaoBD.objCommand.CommandType = CommandType.StoredProcedure
                conexaoBD.objCommand.CommandText = "SpIns_CadastraAcao"
                conexaoBD.objCommand.Parameters.AddWithValue("@NomeAtivo", objAcao.NomeAtivo)
                conexaoBD.objCommand.Parameters.AddWithValue("@SiglaAtivo", objAcao.SiglaAtivo)
                conexaoBD.objCommand.Parameters.AddWithValue("@SetorAtivo", objAcao.SetorAtivo)
                conexaoBD.objCommand.Parameters.AddWithValue("@IdTipoAcao", objAcao.IdTipoAcao)

                conexaoBD.objCommand.ExecuteNonQuery()
                conexaoBD.objConexao.Close()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub

        Shared Sub AlterarAcao(objAcao As Acao)
            Try

                Dim conexaoBD As New ConexaoBD

                conexaoBD.objCommand.CommandType = CommandType.StoredProcedure
                conexaoBD.strInstrucao = "SpUpd_AlteraAcao"
                conexaoBD.objCommand.CommandText = conexaoBD.strInstrucao
                conexaoBD.objCommand.Parameters.AddWithValue("@ID", objAcao.Id)
                conexaoBD.objCommand.Parameters.AddWithValue("@NomeAtivo", objAcao.NomeAtivo)
                conexaoBD.objCommand.Parameters.AddWithValue("@SiglaAtivo", objAcao.SiglaAtivo)
                conexaoBD.objCommand.Parameters.AddWithValue("@SetorAtivo", objAcao.SetorAtivo)
                conexaoBD.objCommand.Parameters.AddWithValue("@IdTipoAcao", objAcao.IdTipoAcao)
                conexaoBD.objCommand.ExecuteNonQuery()
                conexaoBD.objConexao.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Shared Function ConsultarAcao() As DataTable

            Try
                Dim conexaoBD As New ConexaoBD
                Dim Dt As New DataTable
                Dim Ds As New DataSet

                conexaoBD.objCommand.CommandType = CommandType.StoredProcedure
                conexaoBD.strInstrucao = "SpSel_ConsultaAcao"
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

        Shared Sub ExcluirAcao(IDAcao As Integer)

            Try
                Dim ConexaoBD As New ConexaoBD

                ConexaoBD.objCommand.CommandType = CommandType.StoredProcedure
                ConexaoBD.strInstrucao = "spDel_DeletaAcao"
                ConexaoBD.objCommand.CommandText = ConexaoBD.strInstrucao
                ConexaoBD.objCommand.Parameters.AddWithValue("@ID", IDAcao)
                ConexaoBD.objCommand.ExecuteNonQuery()
                ConexaoBD.objConexao.Close()

            Catch ex As Exception

                Throw ex
            End Try



        End Sub

        Shared Function ConsultarTipoAcao() As DataTable

            Try
                Dim ConexaoBD As New ConexaoBD

                Dim Dt As New DataTable
                Dim Ds As New DataSet

                ConexaoBD.objCommand.CommandType = CommandType.Text
                ConexaoBD.objCommand.CommandText = "SELECT * FROM tabTipoAcao"

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

