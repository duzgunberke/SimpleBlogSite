<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YorumGuncelle.aspx.cs" Inherits="BlogSitesiDenemesi.AdminPages.YorumGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <form runat="server" class="form-group">
       
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" PlaceHolder="Blog Başlık" Enabled="false"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" PlaceHolder="Kullanıcı Adı"></asp:TextBox>
         <br />
        <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" PlaceHolder="Yorum İçerik" Height="100px" TextMode="MultiLine" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Güncelle" cssclass="btn btn-success" OnClick="Button1_Click" />


    </form>
</asp:Content>
