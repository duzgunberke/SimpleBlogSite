<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YeniBlog.aspx.cs" Inherits="BlogSitesiDenemesi.AdminPages.YeniBlog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" class="form-group">
       
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" PlaceHolder="Blog Başlık"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" PlaceHolder="Blog Tarih"></asp:TextBox>
         <br />
        <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" PlaceHolder="Blog Görsel"></asp:TextBox>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" DataValueField="TURID" DataTextField="TURAD"></asp:DropDownList>
        <br /> 
        <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control" DataValueField="KATEGORIID" DataTextField="KATEGORIAD"></asp:DropDownList>
        <br />
        <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" PlaceHolder="İçerik..." Height="100px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" cssclass="btn btn-success" OnClick="Button1_Click"/>


    </form>
</asp:Content>
