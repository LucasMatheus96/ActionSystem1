Imports Action.Classes

Imports Action.DAO

Namespace Controller
    Public Class ControladorInvestimento


        Shared Sub InsereInvestimento(objInvestimento As Investimento)
            Try

                InvestimentoDAO.InsereInvestimento(objInvestimento)

            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try
        End Sub

        Shared Sub AlteraInvestimento(objInvestimento As Investimento)
            Try

                InvestimentoDAO.AlteraInvestimento(objInvestimento)

            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try
        End Sub
        Shared Function ConsultaInvestimentos(idOperador As Integer) As DataTable
            Try

                Return InvestimentoDAO.ConsultaInvestimentos(idOperador)

            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function PesquisaInvestimentoPorFiltroData(idOperador As Integer, dataInicial As DateTime, dataFinal As DateTime) As DataTable
            Try

                Return InvestimentoDAO.PesquisaInvestimentoPorFiltroData(idOperador, dataInicial, dataFinal)

            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try
        End Function

        Public Function BuscaInvestimentoNomeCarteira(iOperador As Integer, nomeCarteira As String) As DataTable

            Try

                Return InvestimentoDAO.BuscaInvestimentoNomeCarteira(iOperador, nomeCarteira)

            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try

        End Function


        Public Function BuscaInvestimentoSiglaAtivo(iOperador As Integer, siglaAtivo As String) As DataTable

            Try

                Return InvestimentoDAO.BuscaInvestimentoSiglaAtivo(iOperador, siglaAtivo)

            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try

        End Function

        Public Function BuscaInvestimentoInstFinanceira(iOperador As Integer, instFinanceira As String) As DataTable

            Try

                Return InvestimentoDAO.BuscaInvestimentoInstFinanceira(iOperador, instFinanceira)

            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try

        End Function

        Public Function BuscaInvestimentoTipoAtivo(iOperador As Integer, idtipoAtivo As Integer) As DataTable

            Try

                Return InvestimentoDAO.BuscaInvestimentoTipoAtivo(iOperador, idtipoAtivo)

            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try

        End Function

    End Class




End Namespace

