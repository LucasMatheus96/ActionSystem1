Imports System.Data.SqlClient
Imports Action.Classes
Imports Action.Conexao

Namespace DAO
    Public Class InvestimentoDAO

        Shared Sub InsereInvestimento(objInvestimento As Investimento)

            Try
                Dim conexaoBD As New ConexaoBD

                conexaoBD.strInstrucao = "SpIns_CadastraRegistroInvestimento"
                conexaoBD.objCommand.CommandType = CommandType.StoredProcedure
                conexaoBD.objCommand.CommandText = conexaoBD.strInstrucao
                conexaoBD.objCommand.Parameters.AddWithValue("@NomeAtivo", objInvestimento.NomeAtivo)
                conexaoBD.objCommand.Parameters.AddWithValue("@SiglaAtivo", objInvestimento.SiglaAtivo)
                conexaoBD.objCommand.Parameters.AddWithValue("@IdAtivo", objInvestimento.IdAtivo)
                conexaoBD.objCommand.Parameters.AddWithValue("@Quantidade", objInvestimento.Quantidade)
                conexaoBD.objCommand.Parameters.AddWithValue("@PrecoAtivo", objInvestimento.PrecoAtivo)
                conexaoBD.objCommand.Parameters.AddWithValue("@PrecoMedio", objInvestimento.PrecoMedio)
                conexaoBD.objCommand.Parameters.AddWithValue("@DataTransacao", objInvestimento.DataTransacao)
                conexaoBD.objCommand.Parameters.AddWithValue("@IdCarteira", objInvestimento.IdCarteira)
                conexaoBD.objCommand.Parameters.AddWithValue("@IdTipoAtivo", objInvestimento.IdTipoAtivo)
                conexaoBD.objCommand.ExecuteNonQuery()
                conexaoBD.objConexao.Close()
            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try

        End Sub
        Shared Sub AlteraInvestimento(objInvestimento As Investimento)
            Try
                Dim conexaoBD As New ConexaoBD
                conexaoBD.strInstrucao = "SpUpd_AtualizaRegistroInvestimento"
                conexaoBD.objCommand.CommandType = CommandType.StoredProcedure
                conexaoBD.objCommand.CommandText = conexaoBD.strInstrucao
                conexaoBD.objCommand.Parameters.AddWithValue("@Id", objInvestimento.Id)
                conexaoBD.objCommand.Parameters.AddWithValue("@SiglaAtivo", objInvestimento.SiglaAtivo)
                conexaoBD.objCommand.Parameters.AddWithValue("@IdAtivo", objInvestimento.IdAtivo)
                conexaoBD.objCommand.Parameters.AddWithValue("@Quantidade", objInvestimento.Quantidade)
                conexaoBD.objCommand.Parameters.AddWithValue("@PrecoAtivo", objInvestimento.PrecoAtivo)
                conexaoBD.objCommand.Parameters.AddWithValue("@DataTransacao", objInvestimento.DataTransacao)
                conexaoBD.objCommand.Parameters.AddWithValue("@IdCarteira", objInvestimento.IdCarteira)
                conexaoBD.objCommand.Parameters.AddWithValue("@IdTipoAtivo", objInvestimento.IdTipoAtivo)
                conexaoBD.objCommand.ExecuteNonQuery()
                conexaoBD.objConexao.Close()

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Sub


        Shared Function ConsultaInvestimentos(idOperador As Integer) As DataTable

            Try
                Dim conexaoBD As New ConexaoBD
                Dim Dt As New DataTable
                Dim Ds As New DataSet

                conexaoBD.strInstrucao = "SpSel_ConsultaRegistroInvestimento"
                conexaoBD.objCommand.CommandType = CommandType.StoredProcedure
                conexaoBD.objCommand.CommandText = conexaoBD.strInstrucao
                conexaoBD.objCommand.Parameters.AddWithValue("@iOperador", idOperador)
                conexaoBD.objCommand.ExecuteNonQuery()
                conexaoBD.objConexao.Close()
                Dim Da As New SqlDataAdapter(conexaoBD.objCommand)
                Da.Fill(Ds)
                Dt = Ds.Tables(0)
                Return Dt


            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace


