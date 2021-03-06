﻿Imports System.Data.SqlClient
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
                conexaoBD.objCommand.Parameters.AddWithValue("@PrecoTotal", objInvestimento.PrecoTotal)
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
                conexaoBD.objCommand.Parameters.AddWithValue("@NomeAtivo", IIf(objInvestimento.NomeAtivo IsNot Nothing, objInvestimento.NomeAtivo, DBNull.Value))
                conexaoBD.objCommand.Parameters.AddWithValue("@SiglaAtivo", IIf(objInvestimento.SiglaAtivo IsNot Nothing, objInvestimento.SiglaAtivo, DBNull.Value))
                conexaoBD.objCommand.Parameters.AddWithValue("@IdAtivo", IIf(objInvestimento.IdAtivo <> 0, objInvestimento.IdAtivo, DBNull.Value))
                conexaoBD.objCommand.Parameters.AddWithValue("@PrecoAtivo", IIf(objInvestimento.PrecoAtivo <> 0, objInvestimento.PrecoAtivo, DBNull.Value))
                conexaoBD.objCommand.Parameters.AddWithValue("@Quantidade", IIf(objInvestimento.Quantidade <> 0, objInvestimento.Quantidade, DBNull.Value))
                conexaoBD.objCommand.Parameters.AddWithValue("@PrecoTotal", IIf(objInvestimento.PrecoTotal <> 0, objInvestimento.PrecoTotal, DBNull.Value))
                conexaoBD.objCommand.Parameters.AddWithValue("@IdCarteira", IIf(objInvestimento.IdCarteira <> 0, objInvestimento.IdCarteira, DBNull.Value))
                conexaoBD.objCommand.Parameters.AddWithValue("@IdTipoAtivo", IIf(objInvestimento.IdTipoAtivo <> 0, objInvestimento.IdTipoAtivo, DBNull.Value))
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

        Shared Function PesquisaInvestimentoPorFiltroData(idOperador As Integer, dataInicial As DateTime, dataFinal As DateTime) As DataTable

            Try
                Dim conexaoBD As New ConexaoBD
                Dim Dt As New DataTable
                Dim Ds As New DataSet

                conexaoBD.strInstrucao = " SET DATEFORMAT 'DMY'
                                          SELECT *  FROM [dbAction].[dbo].[tabRegistroInvestimento] AS RI
                                          INNER JOIN tabCarteira AS TC ON TC.Id  = RI.IdCarteira
                                          INNER JOIN tabTipoAtivo as TA on TA.id = Ri.IdTipoAtivo
                                          WHERE TC.iOperador = @iOperador and Ri.DataTransacao between '" + dataInicial + "'" + "And" + "'" + dataFinal + "'"
                conexaoBD.objCommand.Parameters.AddWithValue("@iOperador", idOperador)
                conexaoBD.objCommand.Parameters.AddWithValue("@dataInicial", dataInicial)
                conexaoBD.objCommand.Parameters.AddWithValue("@dataFinal", dataFinal)
                conexaoBD.objCommand.CommandType = CommandType.Text
                conexaoBD.objCommand.CommandText = conexaoBD.strInstrucao
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


        Shared Function BuscaInvestimentoNomeCarteira(idOperador As Integer, nomeCarteira As String) As DataTable
            Try
                Dim conexaoBD As New ConexaoBD
                Dim Dt As New DataTable
                Dim Ds As New DataSet

                conexaoBD.strInstrucao = " 
                                          SELECT *  FROM [dbAction].[dbo].[tabRegistroInvestimento] AS RI
                                          INNER JOIN tabCarteira AS TC ON TC.Id  = RI.IdCarteira
                                          INNER JOIN tabTipoAtivo as TA on TA.id = Ri.IdTipoAtivo    
                                          WHERE TC.iOperador = @iOperador AND TC.NomeCarteira  like '%" + nomeCarteira + "%'"

                conexaoBD.objCommand.Parameters.AddWithValue("@iOperador", idOperador)
                conexaoBD.objCommand.Parameters.AddWithValue("@nomeCarteira", nomeCarteira)
                conexaoBD.objCommand.CommandType = CommandType.Text
                conexaoBD.objCommand.CommandText = conexaoBD.strInstrucao
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
        Shared Function BuscaInvestimentoSiglaAtivo(idOperador As Integer, siglaAtivo As String) As DataTable
            Try
                Dim conexaoBD As New ConexaoBD
                Dim Dt As New DataTable
                Dim Ds As New DataSet

                conexaoBD.strInstrucao = " 
                                          SELECT *  FROM [dbAction].[dbo].[tabRegistroInvestimento] AS RI
                                          INNER JOIN tabCarteira AS TC ON TC.Id  = RI.IdCarteira
                                           INNER JOIN tabTipoAtivo as TA on TA.id = Ri.IdTipoAtivo
                                          WHERE TC.iOperador = @iOperador AND RI.SiglaAtivo  like '%" + siglaAtivo + "%'"

                conexaoBD.objCommand.Parameters.AddWithValue("@iOperador", idOperador)
                conexaoBD.objCommand.Parameters.AddWithValue("@siglaAtivo", siglaAtivo)
                conexaoBD.objCommand.CommandType = CommandType.Text
                conexaoBD.objCommand.CommandText = conexaoBD.strInstrucao
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


        Shared Function BuscaInvestimentoInstFinanceira(idOperador As Integer, instFinanceira As String) As DataTable
            Try
                Dim conexaoBD As New ConexaoBD
                Dim Dt As New DataTable
                Dim Ds As New DataSet

                conexaoBD.strInstrucao = " 
                                          SELECT *  FROM [dbAction].[dbo].[tabRegistroInvestimento] AS RI
                                          INNER JOIN tabCarteira AS TC ON TC.Id  = RI.IdCarteira
                                          INNER JOIN tabTipoAtivo as TA on TA.id = Ri.IdTipoAtivo
                                          WHERE TC.iOperador = @iOperador AND RI.NomeAtivo  like '%" + instFinanceira + "%'"

                conexaoBD.objCommand.Parameters.AddWithValue("@iOperador", idOperador)
                conexaoBD.objCommand.Parameters.AddWithValue("@instFinanceira", instFinanceira)
                conexaoBD.objCommand.CommandType = CommandType.Text
                conexaoBD.objCommand.CommandText = conexaoBD.strInstrucao
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


        Shared Function BuscaInvestimentoTipoAtivo(idOperador As Integer, idtipoAtivo As String) As DataTable
            Try
                Dim conexaoBD As New ConexaoBD
                Dim Dt As New DataTable
                Dim Ds As New DataSet

                conexaoBD.strInstrucao = " 
                                          SELECT *  FROM [dbAction].[dbo].[tabRegistroInvestimento] AS RI
                                          INNER JOIN tabCarteira AS TC ON TC.Id  = RI.IdCarteira
                                           INNER JOIN tabTipoAtivo as TA on TA.id = Ri.IdTipoAtivo
                                          WHERE TC.iOperador = @iOperador AND RI.Idtipoativo =   @idtipoAtivo "

                conexaoBD.objCommand.Parameters.AddWithValue("@iOperador", idOperador)
                conexaoBD.objCommand.Parameters.AddWithValue("@idTipoAtivo", idtipoAtivo)
                conexaoBD.objCommand.CommandType = CommandType.Text
                conexaoBD.objCommand.CommandText = conexaoBD.strInstrucao
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

        Shared Sub ExcluirInvestimento(idInvestimento As Integer)

            Try
                Dim ConexaoBD As New ConexaoBD
                ConexaoBD.strInstrucao = "SpDel_DeletaRegistroInvestimento"
                ConexaoBD.objCommand.Parameters.AddWithValue("@ID", idInvestimento)
                ConexaoBD.objCommand.CommandType = CommandType.StoredProcedure
                ConexaoBD.objCommand.CommandText = ConexaoBD.strInstrucao
                ConexaoBD.objCommand.ExecuteNonQuery()
                ConexaoBD.objConexao.Close()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub
    End Class
End Namespace


