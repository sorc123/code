<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Pocetna.aspx.cs" Inherits="Biblioteka.Pocetna" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Login ID="Login1" runat="server" DestinationPageUrl="~/Pregledi.aspx">
    </asp:Login>
    <p>
    </p>
</asp:Content>
