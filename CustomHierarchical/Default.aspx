<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register TagPrefix="asp" Namespace="CSTruter.com" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
		<asp:TreeView ID="tree" runat="server" DataSourceID="source" ExpandDepth="0">
		</asp:TreeView>
		<asp:HierarchicalObjectDataSource ID="source" runat="server" SelectMethod="GetData"
			TypeName="CSTruter.com.Data" DataParentField="ParentID" DataValueField="Value"
			DataTextField="Text" />
    </div>
    </form>
</body>
</html>
