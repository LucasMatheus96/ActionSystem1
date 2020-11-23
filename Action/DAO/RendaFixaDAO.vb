Imports System.Data.SqlClient
Imports Action.classes
Imports Action.Conexao
Namespace Dao
    Public Class RendaFixaDAO


        Shared Sub CadastrarRendaFixa(RendaFixa As RendaFixa)

            Try
                Dim ConexaoBD As New ConexaoBD

                ConexaoBD.objCommand.CommandType = CommandType.StoredProcedure
                ConexaoBD.objCommand.CommandText = "SpIns_CadastraRendaFixa"
                ConexaoBD.objCommand.Parameters.AddWithValue("@NomeAtivo", RendaFixa.NomeAtivo)
                ConexaoBD.objCommand.Parameters.AddWithValue("@IdTipoRendaFixa", RendaFixa.IdTipoRendaFixa)
                ConexaoBD.objCommand.Parameters.AddWithValue("@Rendimento", RendaFixa.Rendimento)
                
                ConexaoBD.objCommand.ExecuteNonQuery()
                ConexaoBD.objConexao.Close()


            Catch ex As Exception

                Throw New Exception(ex.Message)

            End Try
        End Sub

        Shared Function ConsultarTipoRendaFixa() As DataTable

            Try
                Dim ConexaoBD As New ConexaoBD

                Dim Dt As New DataTable
                Dim Ds As New DataSet

                ConexaoBD.objCommand.CommandType = CommandType.Text
                ConexaoBD.objCommand.CommandText = "SELECT * FROM tabTipoRendaFixa"
                
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

        Shared Function ConsultarRendaFixa() As DataTable

            Try
                Dim ConexaoBD As New ConexaoBD

                Dim Dt As New DataTable
                Dim Ds As New DataSet

                ConexaoBD.objCommand.CommandType = CommandType.StoredProcedure
                ConexaoBD.objCommand.CommandText = "SpSel_ConsultaRendaFixa"
                
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

        Shared Sub ExcluirRendaFixa(IDRendaFixa As Integer)

            Try
                Dim ConexaoBD As New ConexaoBD

                ConexaoBD.objCommand.CommandType = CommandType.StoredProcedure
                ConexaoBD.objCommand.CommandText = "SpDel_DeletaRendaFixa"
                ConexaoBD.objCommand.Parameters.AddWithValue("@ID", IDRendaFixa)
                
                ConexaoBD.objCommand.ExecuteNonQuery()
                ConexaoBD.objConexao.Close()


            Catch ex As Exception

                Throw New Exception(ex.Message)

            End Try
        End Sub



        Shared Sub AlterarRendaFixa(RendaFixa As RendaFixa)

            Try
                Dim ConexaoBD As New ConexaoBD

                ConexaoBD.objCommand.CommandType = CommandType.StoredProcedure
                ConexaoBD.objCommand.CommandText = "SpUpd_AlteraRendaFixa"
                ConexaoBD.objCommand.Parameters.AddWithValue("@ID", RendaFixa.Id)
                ConexaoBD.objCommand.Parameters.AddWithValue("@NomeAtivo", RendaFixa.NomeAtivo)
                ConexaoBD.objCommand.Parameters.AddWithValue("@IdTipoRendaFixa", RendaFixa.IdTipoRendaFixa)
                ConexaoBD.objCommand.Parameters.AddWithValue("@Rendimento", RendaFixa.Rendimento)
                
                ConexaoBD.objCommand.ExecuteNonQuery()
                ConexaoBD.objConexao.Close()


            Catch ex As Exception

                Throw New Exception(ex.Message)

            End Try
        End Sub
    End Class
End Namespace

