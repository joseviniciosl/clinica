gx.evt.autoSkip=false;function viewcalendario(){this.ServerClass="ViewCalendario";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=false;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV11ClinicaCodigo=gx.fn.getControlValue("vCLINICACODIGO");this.AV12CalendarioCodigo=gx.fn.getControlValue("vCALENDARIOCODIGO");this.AV7TabCode=gx.fn.getControlValue("vTABCODE")};this.e132d2_client=function(){this.executeServerEvent("ENTER",true)};this.e142d2_client=function(){this.executeServerEvent("CANCEL",true)
};this.GXValidFnc=[];this.GXCtrlIds=[2,5,8,10,13,16,18,19];this.GXLastCtrlId=19;this.GXValidFnc[2]={fld:"VIEWTABLE",grid:0};this.GXValidFnc[5]={fld:"TITLETABLE",grid:0};this.GXValidFnc[8]={fld:"VIEWTITLE",format:0,grid:0};this.GXValidFnc[10]={fld:"VIEWALL",format:0,grid:0};this.GXValidFnc[13]={fld:"TABLE1",grid:0};this.GXValidFnc[16]={fld:"FIXTEXTCALENDARIOOBS",format:0,grid:0};this.GXValidFnc[18]={lvl:0,type:"svchar",len:600,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"CALENDARIOOBS",gxz:"Z234CalendarioObs",gxold:"O234CalendarioObs",gxvar:"A234CalendarioObs",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A234CalendarioObs=a
},v2z:function(a){gx.O.Z234CalendarioObs=a},v2c:function(){gx.fn.setControlValue("CALENDARIOOBS",gx.O.A234CalendarioObs,0)},c2v:function(){gx.O.A234CalendarioObs=this.val()},val:function(){return gx.fn.getControlValue("CALENDARIOOBS")},nac:function(){return false}};this.GXValidFnc[19]={fld:"SPACESEPARATOR",format:0,grid:0};this.A234CalendarioObs="";this.Z234CalendarioObs="";this.O234CalendarioObs="";this.AV11ClinicaCodigo="";this.AV12CalendarioCodigo="";this.AV7TabCode="";this.A233CalendarioCodigo="";
this.A41ClinicaCodigo="";this.ServerEvents=["e132d2_client","e142d2_client"];this.VarControlMap.AV11ClinicaCodigo={id:"vCLINICACODIGO",grid:0,type:"svchar"};this.VarControlMap.AV12CalendarioCodigo={id:"vCALENDARIOCODIGO",grid:0,type:"svchar"};this.VarControlMap.AV7TabCode={id:"vTABCODE",grid:0,type:"char"};this.SetStandaloneVars();this.setComponent({id:"TABBEDVIEW",GXClass:null,Prefix:"W0022",lvl:1})}viewcalendario.prototype=new gx.GxObject;gx.setParentObj(new viewcalendario());