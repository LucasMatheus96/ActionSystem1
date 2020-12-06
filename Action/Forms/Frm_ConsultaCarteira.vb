﻿Imports Action.classes
Imports Action.Controller

Public Class Frm_ConsultaCarteira
    Dim Index As Integer = 0
    Dim objCarteira As New Carteira
    Dim controlCarteira As New ControladorCarteira
    Dim dt As New DataTable
    Dim objUsuarioLogado As New Usuario
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "Consulta Carteira"
        txt_busca1.Visible = False
        txt_busca2.Visible = False
        CarregarListViewer()
        PreencheComboBox()

    End Sub


    Private Sub CarregarListViewer()
        'ADICIONA AO OBJETO USUARIO O NOME DO USUARIO QUE ESTA LOGADO
        objUsuarioLogado.Usuario = GetUsuarioLogado()


        'POPULA O OJBETO USUARIO DE ACORDO COM O QUE TA SENDO USADO
        SetObjetoUsuarioLogado(objUsuarioLogado)

        'LIMPA TODOS OS ITENS DO LIST VIEW
        Lsw_VerCarteira.Items.Clear()

        'ADICIONA AO DATATABLE A CONSULTA DE TODAS AS CARTEIRAS CADASTRADAS
        dt = controlCarteira.ConsultarCarteira()

        'PECORRE TODO O DATA TABLE TODAS COM AS CARTEIRAS CADASTRADAS
        For Each linha As DataRow In dt.Rows

            'FILTRA APENAS AS CARTEIRAS REFERENTE AO USUARIO LOGADO
            If objUsuarioLogado.Usuario = linha(11) Then
                Dim lista As New ListViewItem()
                lista.Text = linha("Id").ToString()
                lista.SubItems.Add(linha("NomeCarteira").ToString())
                lista.SubItems.Add(linha("DataTransacao").ToString())
                lista.SubItems.Add(linha("Usuario").ToString())


                Lsw_VerCarteira.Items.Add(lista)
            End If


        Next


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Try
            If Lsw_VerCarteira.Items.Count > 0 Then
                Dim AlterarCarteira As New Frm_CadastroCarteira
                AlterarCarteira.IdCarteira = Integer.Parse(Lsw_VerCarteira.Items(Index).Text)
                AlterarCarteira.Txt_NomeCarteira.Text = Lsw_VerCarteira.Items(Index).SubItems(1).Text
                AlterarCarteira.ShowDialog()
                CarregarListViewer()
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Lsw_VerCarteira_Click(sender As Object, e As EventArgs) Handles Lsw_VerCarteira.Click

        Try
            If Lsw_VerCarteira.SelectedItems.Count > 0 Then

                Index = Lsw_VerCarteira.SelectedItems(0).Index

            End If
        Catch ex As Exception

            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            If Lsw_VerCarteira.SelectedItems.Count > 0 Then
                objCarteira.Id = (Integer.Parse(Lsw_VerCarteira.SelectedItems(0).Text))
                controlCarteira.ExcluirCarteira(objCarteira.Id)
                CarregarListViewer()
            End If
        Catch ex As Exception

            Throw New Exception(ex.Message)
        End Try

    End Sub

    'CONFIGURAÇÃO DOS CAMPOS QUE IRÃO SER MOSTRADO DE ACORDO COM A OPÇÃO SELECIONADA NO COMBOBOX
    Private Sub Cmb_Filtro_SelectedValueChanged(sender As Object, e As EventArgs) Handles Cmb_Filtro.SelectedValueChanged

        If Cmb_Filtro.SelectedIndex = 0 Then
            txt_busca1.Visible = False
            txt_busca2.Visible = False
            Dtp_FiltroInicio.Visible = False
            Dtp_FiltroFinal.Visible = False
            Lbl_a.Text = ""
        ElseIf Cmb_Filtro.SelectedIndex = 1 Then

            txt_busca1.Visible = False
            txt_busca2.Visible = False
            Dtp_FiltroInicio.Visible = True
            Dtp_FiltroFinal.Visible = True
            Dtp_FiltroInicio.Width = 100
            Dtp_FiltroInicio.Width = 100
            Lbl_a.Text = "a"
        Else
            txt_busca1.Visible = True
            txt_busca1.Width = 300
            txt_busca2.Visible = False
            Dtp_FiltroInicio.Visible = False
            Dtp_FiltroFinal.Visible = False
            Lbl_a.Text = ""

        End If
    End Sub


    ''BUSCA AUTOMATICA ATRAVÉS DO CAMPO TEXTBOX, AO DIGITAR O SISTEMA JÁ FAZ A BUSCA NO BANCO DE DADOS
    Private Sub txt_busca1_TextChanged(sender As Object, e As EventArgs) Handles txt_busca1.TextChanged

        'LIMPA TODOS OS ITEMS DAL ISTA
        Lsw_VerCarteira.Items.Clear()

        ' ATUALIZA A FONTE DE DADOS DE ACORDO COM AS INFORMAÇÕES TRAZIDAS DO BANCO DE DADOS
        dt = controlCarteira.PesquisarCarteira(txt_busca1.Text)

        'PECORRER O NOVO DT E ADICIONA PARA SER EXIBIDO
        For Each linha As DataRow In dt.Rows
            If objUsuarioLogado.Usuario = linha(11) Then
                Dim lista As New ListViewItem()
                lista.Text = linha("Id").ToString()
                lista.SubItems.Add(linha("NomeCarteira").ToString())
                lista.SubItems.Add(linha("DataTransacao").ToString())
                lista.SubItems.Add(linha("Usuario").ToString())
                Lsw_VerCarteira.Items.Add(lista)
            End If
        Next






    End Sub


    Private Sub PreencheComboBox()

        'CRIA A LISTA COM AS OPÇÕES QUE ESTARÃO DISPONIVEL NO COMBOBOX
        Dim lista As New List(Of String)
        lista.Add("<Selecione>")
        lista.Add("Data")
        lista.Add("Nome da carteira")

        'PECORRE A LISTA CRIADA E ADICIONA OS VALORES AO COMBOBOX
        For i As Integer = 0 To lista.Count - 1
            Cmb_Filtro.Items.Add(lista(i))
        Next

        'DEFINE COMO O COMBOBOX SERÁ INICIADO
        Cmb_Filtro.SelectedIndex = 0
        txt_busca1.Visible = False
        txt_busca2.Visible = False



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If Cmb_Filtro.SelectedIndex = 0 Then
            MessageBox.Show("Selecione um tipo de filtro")
            Cmb_Filtro.Focus()
        End If

        'FILTRO POR DATA
        If Cmb_Filtro.SelectedIndex = 1 Then
            Lsw_VerCarteira.Items.Clear()
            dt = controlCarteira.PesquisarCarteiraData(Dtp_FiltroInicio.Value, Dtp_FiltroFinal.Value)

            For Each linha As DataRow In dt.Rows
                If objUsuarioLogado.Usuario = linha(11) Then
                    Dim lista As New ListViewItem
                    lista.Text = linha("ID").ToString
                    lista.SubItems.Add(linha("NomeCarteira").ToString())
                    lista.SubItems.Add(linha("DataTransacao").ToString())
                    lista.SubItems.Add(linha("Usuario").ToString())

                    Lsw_VerCarteira.Items.Add(lista)
                End If
            Next
        End If
        'BUSCA POR NOME DA CARTEIRA



        If Cmb_Filtro.SelectedIndex = 2 Then
            Lsw_VerCarteira.Items.Clear()
            dt = controlCarteira.PesquisarCarteira(txt_busca1.Text)
            If String.IsNullOrEmpty(txt_busca1.Text) Then
                MessageBox.Show("Digite o nome da carteira")
            Else
                For Each linha As DataRow In dt.Rows
                    If objUsuarioLogado.Usuario = linha("Usuario") Then
                        Dim lista As New ListViewItem
                        lista.Text = linha("ID").ToString
                        lista.SubItems.Add(linha("NomeCarteira").ToString())
                        lista.SubItems.Add(linha("DataTransacao").ToString())
                        lista.SubItems.Add(linha("Usuario").ToString())

                        Lsw_VerCarteira.Items.Add(lista)
                    End If
                Next
                'Lsw_VerCarteira.Items.Clear()
                'Dim criterioPesquisa = From aux In dt Where aux.Item("NomeCarteira") _
                '                                      = Val(txt_busca1.Text.ToString)
                '                       Select aux
                'For Each linha As DataRow In criterioPesquisa

                '    Dim lista As New ListViewItem()
                '    lista.Text = linha("Id").ToString()
                '    lista.SubItems.Add(linha("NomeCarteira").ToString())
                '    lista.SubItems.Add(linha("DataTransacao").ToString())
                '    lista.SubItems.Add(linha("iOperador").ToString())


                '    Lsw_VerCarteira.Items.Add(lista)
                'Next

            End If
        End If

    End Sub
    Private Function GetUsuarioLogado() As String

        Dim usuariologado As String = Frm_Principal.Tsl_UsuarioLogado.Text
        Dim indice1 As Integer = usuariologado.IndexOf(":")
        Dim NovoUsuarioLogado As String = usuariologado.Substring(indice1 + 2)

        Return NovoUsuarioLogado

    End Function

    Private Function SetObjetoUsuarioLogado(objUsuarioLogado As Usuario) As Usuario
        Dim controlUsuario As New ControladorUsuario
        dt = controlUsuario.ConsultarUsuarioLogado(objUsuarioLogado)
        objUsuarioLogado.Id = dt.Rows(0).Item(0)
        objUsuarioLogado.Nome = dt.Rows(0).Item(1)
        objUsuarioLogado.Usuario = dt.Rows(0).Item(2)
        objUsuarioLogado.Senha = dt.Rows(0).Item(3)
        objUsuarioLogado.DataCadastro = dt.Rows(0).Item(4)
        objUsuarioLogado.Permissao = dt.Rows(0).Item(5)

        Return objUsuarioLogado
    End Function

    Private Sub Frm_ConsultaCarteira_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class