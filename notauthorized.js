gx.evt.autoSkip=false;function notauthorized(){this.ServerClass="NotAuthorized";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=false;this.autoRefresh=true;this.SetStandaloneVars=function(){this.GxObject=gx.fn.getControlValue("vGXOBJECT")};this.e13292_client=function(){this.executeServerEvent("ENTER",true)};this.e14292_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[4,7,13,16];this.GXLastCtrlId=16;this.GXValidFnc[4]={fld:"TABLE1",grid:0};
this.GXValidFnc[7]={fld:"TITLETEXT",format:0,grid:0};this.GXValidFnc[13]={fld:"TABLE2",grid:0};this.GXValidFnc[16]={fld:"TABLE3",grid:0};this.GxObject="";this.ServerEvents=["e13292_client","e14292_client"];this.VarControlMap.GxObject={id:"vGXOBJECT",grid:0,type:"svchar"};this.SetStandaloneVars();this.setComponent({id:"HEADERBC",GXClass:null,Prefix:"W0002",lvl:1});this.setComponent({id:"RECENTLINKS",GXClass:null,Prefix:"W0003",lvl:1})}notauthorized.prototype=new gx.GxObject;gx.setParentObj(new notauthorized());