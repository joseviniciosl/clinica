gx.evt.autoSkip=false;function wp_registraexpediente(){this.ServerClass="wp_registraexpediente";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=false;this.autoRefresh=true;this.SetStandaloneVars=function(){};this.e121s2_client=function(){this.executeServerEvent("'GUARDAR'",false)};this.e131s2_client=function(){this.executeServerEvent("'FINALIZAR'",false)};this.e151s2_client=function(){this.executeServerEvent("ENTER",true)};this.e161s2_client=function(){this.executeServerEvent("CANCEL",true)
};this.GXValidFnc=[];this.GXCtrlIds=[2,5,11,14,16,18,20,23,25,27,29,32,35,37,40,43,45,49,51];this.GXLastCtrlId=51;this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[5]={fld:"TEXTBLOCK1",format:0,grid:0};this.GXValidFnc[11]={fld:"TABLE2",grid:0};this.GXValidFnc[14]={fld:"TEXTBLOCK8",format:0,grid:0};this.GXValidFnc[16]={lvl:0,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vPACIENTEID",gxz:"ZV7PacienteId",gxold:"OV7PacienteId",gxvar:"AV7PacienteId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7PacienteId=gx.num.intval(a)
},v2z:function(a){gx.O.ZV7PacienteId=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vPACIENTEID",gx.O.AV7PacienteId,0)},c2v:function(){gx.O.AV7PacienteId=this.val()},val:function(){return gx.fn.getIntegerValue("vPACIENTEID",",")},nac:function(){return false}};this.GXValidFnc[18]={fld:"TEXTBLOCK7",format:0,grid:0};this.GXValidFnc[20]={lvl:0,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vEXPEDIENTEID",gxz:"ZV8ExpedienteId",gxold:"OV8ExpedienteId",gxvar:"AV8ExpedienteId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV8ExpedienteId=gx.num.intval(a)
},v2z:function(a){gx.O.ZV8ExpedienteId=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vEXPEDIENTEID",gx.O.AV8ExpedienteId,0)},c2v:function(){gx.O.AV8ExpedienteId=this.val()},val:function(){return gx.fn.getIntegerValue("vEXPEDIENTEID",",")},nac:function(){return false}};this.GXValidFnc[23]={fld:"TEXTBLOCK5",format:0,grid:0};this.GXValidFnc[25]={lvl:0,type:"date",len:8,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vEXPEDIENTEFECHA",gxz:"ZV9ExpedienteFecha",gxold:"OV9ExpedienteFecha",gxvar:"AV9ExpedienteFecha",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV9ExpedienteFecha=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.ZV9ExpedienteFecha=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setControlValue("vEXPEDIENTEFECHA",gx.O.AV9ExpedienteFecha,0)},c2v:function(){gx.O.AV9ExpedienteFecha=this.val()},val:function(){return gx.fn.getControlValue("vEXPEDIENTEFECHA")},nac:function(){return false}};this.GXValidFnc[27]={fld:"TEXTBLOCK6",format:0,grid:0};this.GXValidFnc[29]={lvl:0,type:"char",len:8,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vEXPEDIENTEHORA",gxz:"ZV10ExpedienteHora",gxold:"OV10ExpedienteHora",gxvar:"AV10ExpedienteHora",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV10ExpedienteHora=a
},v2z:function(a){gx.O.ZV10ExpedienteHora=a},v2c:function(){gx.fn.setControlValue("vEXPEDIENTEHORA",gx.O.AV10ExpedienteHora,0)},c2v:function(){gx.O.AV10ExpedienteHora=this.val()},val:function(){return gx.fn.getControlValue("vEXPEDIENTEHORA")},nac:function(){return false}};this.GXValidFnc[32]={fld:"TABLE3",grid:0};this.GXValidFnc[35]={fld:"TEXTBLOCK9",format:0,grid:0};this.GXValidFnc[37]={lvl:0,type:"svchar",len:600,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vEXPEDIENTEOBS",gxz:"ZV11ExpedienteObs",gxold:"OV11ExpedienteObs",gxvar:"AV11ExpedienteObs",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV11ExpedienteObs=a
},v2z:function(a){gx.O.ZV11ExpedienteObs=a},v2c:function(){gx.fn.setControlValue("vEXPEDIENTEOBS",gx.O.AV11ExpedienteObs,0)},c2v:function(){gx.O.AV11ExpedienteObs=this.val()},val:function(){return gx.fn.getControlValue("vEXPEDIENTEOBS")},nac:function(){return false}};this.GXValidFnc[40]={fld:"TABLE4",grid:0};this.GXValidFnc[43]={fld:"TEXTBLOCK11",format:0,grid:0};this.GXValidFnc[45]={lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vEXPEDIENTEDESCRIPCION",gxz:"ZV13ExpedienteDescripcion",gxold:"OV13ExpedienteDescripcion",gxvar:"AV13ExpedienteDescripcion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV13ExpedienteDescripcion=a
},v2z:function(a){gx.O.ZV13ExpedienteDescripcion=a},v2c:function(){gx.fn.setControlValue("vEXPEDIENTEDESCRIPCION",gx.O.AV13ExpedienteDescripcion,0)},c2v:function(){gx.O.AV13ExpedienteDescripcion=this.val()},val:function(){return gx.fn.getControlValue("vEXPEDIENTEDESCRIPCION")},nac:function(){return false}};this.GXValidFnc[49]={fld:"TEXTBLOCK10",format:0,grid:0};this.GXValidFnc[51]={lvl:0,type:"bitstr",len:1024,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vEXPEDIENTEARCHIVO",gxz:"ZV14ExpedienteArchivo",gxold:"OV14ExpedienteArchivo",gxvar:"AV14ExpedienteArchivo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV14ExpedienteArchivo=a
},v2z:function(a){gx.O.ZV14ExpedienteArchivo=a},v2c:function(){gx.fn.setBlobValue("vEXPEDIENTEARCHIVO",gx.O.AV14ExpedienteArchivo)},c2v:function(){gx.O.AV14ExpedienteArchivo=this.val()},val:function(){return gx.fn.getBlobValue("vEXPEDIENTEARCHIVO")},nac:function(){return false}};this.AV7PacienteId=0;this.ZV7PacienteId=0;this.OV7PacienteId=0;this.AV8ExpedienteId=0;this.ZV8ExpedienteId=0;this.OV8ExpedienteId=0;this.AV9ExpedienteFecha=gx.date.nullDate();this.ZV9ExpedienteFecha=gx.date.nullDate();this.OV9ExpedienteFecha=gx.date.nullDate();
this.AV10ExpedienteHora="";this.ZV10ExpedienteHora="";this.OV10ExpedienteHora="";this.AV11ExpedienteObs="";this.ZV11ExpedienteObs="";this.OV11ExpedienteObs="";this.AV13ExpedienteDescripcion="";this.ZV13ExpedienteDescripcion="";this.OV13ExpedienteDescripcion="";this.AV14ExpedienteArchivo="";this.ZV14ExpedienteArchivo="";this.OV14ExpedienteArchivo="";this.ServerEvents=["e121s2_client","e131s2_client","e151s2_client","e161s2_client"];this.SetStandaloneVars()}wp_registraexpediente.prototype=new gx.GxObject;
gx.setParentObj(new wp_registraexpediente());