﻿Public Class Frm_Principal
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "Action"

    End Sub

    Private Sub Frm_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As New Frm_Login
        f.ShowDialog()
    End Sub

    Private Sub CadastrarCarteiraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarCarteiraToolStripMenuItem.Click
        Dim f As New Frm_CadastroCarteira
        f.ShowDialog()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub Tsl_UsuarioLogado_Click(sender As Object, e As EventArgs) Handles Tsl_UsuarioLogado.Click

    End Sub

    Private Sub ConsultarCarteiraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarCarteiraToolStripMenuItem.Click
        Dim f As New Frm_ConsultaCarteira
        f.ShowDialog()
    End Sub

    Private Sub EfetuarNovoAcessoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EfetuarNovoAcessoToolStripMenuItem.Click

        Dim f1 As New Frm_Login
        f1.ShowDialog()
    End Sub

    Private Sub CadastrarAtivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarAtivosToolStripMenuItem.Click
        Dim f As New Frm_CadastrarAtivo
        f.ShowDialog()
    End Sub

    Private Sub ConsultarAtivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarAtivosToolStripMenuItem.Click
        Dim f As New Frm_ConsultarAtivo
        f.ShowDialog()
    End Sub

    Private Sub AdicionarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdicionarToolStripMenuItem.Click
        Dim f As New Frm_ProdutoCarteira
        f.ShowDialog()
    End Sub

    Private Sub GerenciarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerenciarToolStripMenuItem.Click
        Dim f As New Frm_GerenciarProduto
        f.ShowDialog()

    End Sub

    Private Sub CadastroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Pnl_Top.Paint

    End Sub

    Private Sub Btn_CadastrarCarteira_Click(sender As Object, e As EventArgs) Handles Btn_CadastrarCarteira.Click
        Dim f As New Frm_CadastroCarteira
        f.ShowDialog()
    End Sub

    Private Sub Btn_ConsultarCarteira_Click(sender As Object, e As EventArgs) Handles Btn_ConsultarCarteira.Click
        Dim f As New Frm_ConsultaCarteira
        f.ShowDialog()
    End Sub

    Private Sub Btn_AdicionarInvestimento_Click(sender As Object, e As EventArgs) Handles Btn_AdicionarInvestimento.Click
        Dim f As New Frm_ProdutoCarteira
        f.ShowDialog()
    End Sub

    Private Sub Btn_GerenciarInvestimento_Click(sender As Object, e As EventArgs) Handles Btn_GerenciarInvestimento.Click
        Dim f As New Frm_GerenciarProduto
        f.ShowDialog()
    End Sub

    Private Sub Btn_Cadastraativos_Click(sender As Object, e As EventArgs) Handles Btn_Cadastraativos.Click
        Dim f As New Frm_CadastrarAtivo
        f.ShowDialog()
    End Sub

    Private Sub Btn_ConsultarAtivos_Click(sender As Object, e As EventArgs) Handles Btn_ConsultarAtivos.Click
        Dim f As New Frm_ConsultarAtivo
        f.ShowDialog()
    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem.Click
        Dim f As New Frm_UsuariosCadastrados
        f.ShowDialog()
    End Sub
End Class