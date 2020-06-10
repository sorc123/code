<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Konvertor.aspx.cs" Inherits="Konvertor_teksta.Konvertor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 22px; top: 63px; position: absolute; height: 21px; width: 44px" Text="Latinica:"></asp:Label>
<p style="height: 302px; width: 505px">
</p>
<asp:Label ID="Label2" runat="server" style="z-index: 1; left: 259px; top: 65px; position: absolute" Text="Cirilica:"></asp:Label>
<asp:TextBox ID="TextBoxLatinica" runat="server" style="z-index: 1; left: 23px; top: 101px; position: absolute; height: 127px; width: 170px" TextMode="MultiLine"></asp:TextBox>
<asp:TextBox ID="TextBoxCirilica" runat="server" style="z-index: 1; left: 252px; top: 103px; position: absolute; height: 122px; width: 170px" TextMode="MultiLine"></asp:TextBox>
<asp:Button ID="ButtonUCirilicu" runat="server" OnClick="ButtonUCirilicu_Click" style="z-index: 1; left: 73px; top: 261px; position: absolute" Text="U cirilicu" CssClass="dugme" />
<asp:Button ID="ButtonULatinicu" runat="server" style="z-index: 1; left: 297px; top: 266px; position: absolute" Text="U latinicu" OnClick="ButtonULatinicu_Click" CssClass="dugme" />
</asp:Content>
