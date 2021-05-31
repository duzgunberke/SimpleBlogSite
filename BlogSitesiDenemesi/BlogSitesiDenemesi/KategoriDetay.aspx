<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanıcı.Master" AutoEventWireup="true" CodeBehind="KategoriDetay.aspx.cs" Inherits="BlogSitesiDenemesi.KategoriDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" >
        <div class="content-grids">
            <div class="col-md-8 content-main">
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <div class="content-grid">
                            <div class="content-grid-info">
                                <img src="<%# Eval("BLOGGORSEL") %>" alt="" style="width: 100%" />
                                <div class="post-info">
                                    <h4><a href="BlogDetay.aspx?BLOGID=<%# Eval("BLOGID") %>"><%# Eval("BLOGBASLIK") %></a><span style="float: right"><%# Eval("BLOGTARIH") %></span></h4>
                                    <p><%# Eval("BLOGICERIK") %></p>
                                    <a href="BlogDetay.aspx?BLOGID=<%# Eval("BLOGID") %>"><span></span>Devam...</a>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>

            </div>
            <div class="col-md-4 content-right">
                <div class="categories">
                    <h3>KATEGORİLER</h3>
                    <ul>
                        <asp:Repeater ID="Repeater2" runat="server">
                            <ItemTemplate>
                                <li><a href="KategoriDetay.aspx?KATEGORIID=<%# Eval("KATEGORIID") %>"><%# Eval("KATEGORIAD") %></a></li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
                <br />
                <div class="recent">
                    <h3>EN SON BLOGLAR</h3>
                    <ul>
                        <asp:Repeater ID="Repeater3" runat="server">
                            <ItemTemplate>
                                <li><a href="#"><%# Eval("BLOGBASLIK") %></a></li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>

                <div class="comments">
                    <h3>SON YORUMLAR</h3>
                    <ul>
                        <li><a href="#">Amada Doe </a> on <a href="#">Hello World!</a></li>
                        <li><a href="#">Peter Doe </a> on <a href="#">Photography</a></li>
                        <li><a href="#">Steve Roberts  </a> on <a href="#">HTML5/CSS3</a></li>
                    </ul>
                </div>
                <div class="clearfix"></div>
                <div class="archives" style="background-color:#eec1c1; border-radius:10px;text-align:center;text-decoration-color:black">
                    <br />
                    <h3>ARŞİVLER</h3>
                    <ul>
                        <li><a href="#">October 2013</a></li>
                        <li><a href="#">September 2013</a></li>
                        <li><a href="#">August 2013</a></li>
                        <li><a href="#">July 2013</a></li>
                    </ul>
                    <br />

                </div>
                <div class="clearfix"></div>

            </div>
            <div class="clearfix"></div>
        </div>
    </div>
</asp:Content>
