gx.evt.autoSkip=false;function wp_reportescontables(){this.ServerClass="wp_reportescontables";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=false;this.autoRefresh=true;this.SetStandaloneVars=function(){};this.e123b2_client=function(){this.executeServerEvent("'REGRESAR'",false)};this.e133b2_client=function(){this.executeServerEvent("'GENERAR'",false)};this.e153b2_client=function(){this.executeServerEvent("ENTER",true)};this.e163b2_client=function(){this.executeServerEvent("CANCEL",true)
};this.GXValidFnc=[];this.GXCtrlIds=[2,5,11,14,16,19,21,24,27,29,32,34];this.GXLastCtrlId=34;this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[5]={fld:"TEXTBLOCK1",format:0,grid:0};this.GXValidFnc[11]={fld:"TABLE2",grid:0};this.GXValidFnc[14]={fld:"TEXTBLOCK5",format:0,grid:0};this.GXValidFnc[16]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vMES",gxz:"ZV7Mes",gxold:"OV7Mes",gxvar:"AV7Mes",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.AV7Mes=gx.num.intval(a)
},v2z:function(a){gx.O.ZV7Mes=gx.num.intval(a)},v2c:function(){gx.fn.setComboBoxValue("vMES",gx.O.AV7Mes)},c2v:function(){gx.O.AV7Mes=this.val()},val:function(){return gx.fn.getIntegerValue("vMES",",")},nac:function(){return false}};this.GXValidFnc[19]={fld:"TEXTBLOCK4",format:0,grid:0};this.GXValidFnc[21]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vANIO",gxz:"ZV8Anio",gxold:"OV8Anio",gxvar:"AV8Anio",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV8Anio=gx.num.intval(a)
},v2z:function(a){gx.O.ZV8Anio=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vANIO",gx.O.AV8Anio,0)},c2v:function(){gx.O.AV8Anio=this.val()},val:function(){return gx.fn.getIntegerValue("vANIO",",")},nac:function(){return false}};this.GXValidFnc[24]={fld:"TABLE3",grid:0};this.GXValidFnc[27]={fld:"TEXTBLOCK6",format:0,grid:0};this.GXValidFnc[29]={lvl:0,type:"svchar",len:1,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vTIPO",gxz:"ZV9Tipo",gxold:"OV9Tipo",gxvar:"AV9Tipo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.AV9Tipo=a
},v2z:function(a){gx.O.ZV9Tipo=a},v2c:function(){gx.fn.setComboBoxValue("vTIPO",gx.O.AV9Tipo)},c2v:function(){gx.O.AV9Tipo=this.val()},val:function(){return gx.fn.getControlValue("vTIPO")},nac:function(){return false}};this.GXValidFnc[32]={fld:"TEXTBLOCK7",format:0,grid:0};this.GXValidFnc[34]={lvl:0,type:"int",len:1,dec:0,sign:false,pic:"9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vREPORTE",gxz:"ZV11Reporte",gxold:"OV11Reporte",gxvar:"AV11Reporte",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.AV11Reporte=gx.num.intval(a)
},v2z:function(a){gx.O.ZV11Reporte=gx.num.intval(a)},v2c:function(){gx.fn.setComboBoxValue("vREPORTE",gx.O.AV11Reporte)},c2v:function(){gx.O.AV11Reporte=this.val()},val:function(){return gx.fn.getIntegerValue("vREPORTE",",")},nac:function(){return false}};this.AV7Mes=0;this.ZV7Mes=0;this.OV7Mes=0;this.AV8Anio=0;this.ZV8Anio=0;this.OV8Anio=0;this.AV9Tipo="";this.ZV9Tipo="";this.OV9Tipo="";this.AV11Reporte=0;this.ZV11Reporte=0;this.OV11Reporte=0;this.ServerEvents=["e123b2_client","e133b2_client","e153b2_client","e163b2_client"];
this.SetStandaloneVars()}wp_reportescontables.prototype=new gx.GxObject;gx.setParentObj(new wp_reportescontables());