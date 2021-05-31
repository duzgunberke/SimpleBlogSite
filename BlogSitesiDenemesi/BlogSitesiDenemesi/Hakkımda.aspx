<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanıcı.Master" AutoEventWireup="true" CodeBehind="Hakkımda.aspx.cs" Inherits="BlogSitesiDenemesi.Hakkımda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2>Something About Me and Blogging</h2>
        <div class="about-section">
            <div class="about-grid">
                <h3>Hakkımızda</h3>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <p><%# Eval("ACIKLAMA") %></p>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
