/*
               File: default
        Description: default
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 20:56:41.4
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
function default() {
   this.ServerClass =  "default" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.hasEnterEvent = false;
   this.autoRefresh = true;
   this.SetStandaloneVars=function()
   {
   };
   this.e133n2_client=function()
   {
      this.executeServerEvent("ENTER", true);
   };
   this.e143n2_client=function()
   {
      this.executeServerEvent("CANCEL", true);
   };
   this.GXValidFnc = [];
   this.GXLastCtrlId =0;
   this.ServerEvents = ["e133n2_client" ,"e143n2_client"];
   this.SetStandaloneVars( );
}
default.prototype = new gx.GxObject;
gx.setParentObj(new default());
