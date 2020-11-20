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
                conexaoBD.objConexao.Open()
                conexaoBD.objCommand.ExecuteNonQuery()
                conexaoBD.objConexao.Close()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try




        End Sub

    End Class
End Namespace

