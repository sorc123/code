<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Pregledi.aspx.cs" Inherits="Biblioteka.Pregledi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" style="z-index: 1; left: 43px; top: 79px; position: absolute; height: 133px; width: 281px">
        <Columns>
            <asp:BoundField DataField="ISBN" HeaderText="ISBN" />
            <asp:BoundField DataField="Naslov" HeaderText="Naslov" />
            <asp:BoundField DataField="Stanje" HeaderText="Stanje" />
            <asp:BoundField DataField="Citano" HeaderText="Citano" />
        </Columns>
    </asp:GridView>
    <p style="height: 229px; width: 471px">
    </p>
</asp:Content>
