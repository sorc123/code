<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Sortiranje_tabele.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sortiranje tabele</title>
    <link href="Css/index.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <table id="MojaTabela">
           <tr>
               <th><a href="#">Rbr</a></th>
               <th><a href="#">Ime</a></th>
               <th><a href="#">Prezime</a></th>
           </tr>

           <tr>
               <td>1.</td>
               <td>Pera</td>
               <td>Mikic</td>
           </tr>
           
           <tr>
               <td>2.</td>
               <td>Mika</td>
               <td>Zikic</td>
           </tr>
           
           <tr>
               <td>3.</td>
               <td>Zika</td>
               <td>Peric</td>
           </tr>

           <tr>
               <td>4.</td>
               <td>Cika</td>
               <td>Mokic</td>
           </tr>
       </table>
    </div>
    </form>

    <a href="O_aplikaciji.aspx">Informacije o autoru i aplikaciji</a>

    <script src="Js/index.js"></script>
</body>
</html>
