gx.evt.autoSkip=false;function wp_registraconsulta(){this.ServerClass="wp_registraconsulta";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=false;this.autoRefresh=true;this.SetStandaloneVars=function(){};this.e181j1_client=function(){this.clearMessages();this.refreshOutputs([])};this.e121j2_client=function(){this.executeServerEvent("'REGRESAR'",false)};this.e131j2_client=function(){this.executeServerEvent("'FINALIZAR CONSULTA'",false)};this.e141j2_client=function(){this.executeServerEvent("'CARGOS'",false)
};this.e151j2_client=function(){this.executeServerEvent("'RECETA'",false)};this.e161j2_client=function(){this.executeServerEvent("'SIGNOS VITALES'",false)};this.e191j2_client=function(){this.executeServerEvent("ENTER",true)};this.e201j2_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[2,5,11,14,17,19,21,23,25,27,30,33,35,37,39,41,43,46,48,50,52,54,56,59,61,63,65,67,69,72,75,77,79,81,83,85,88,91,93,96,99,101,104,107,109];this.GXLastCtrlId=109;this.GXValidFnc[2]={fld:"TABLE1",grid:0};
this.GXValidFnc[5]={fld:"TEXTBLOCK1",format:0,grid:0};this.GXValidFnc[11]={fld:"TABLE2",grid:0};this.GXValidFnc[14]={fld:"TABLE3",grid:0};this.GXValidFnc[17]={fld:"TEXTBLOCK2",format:0,grid:0};this.GXValidFnc[19]={lvl:0,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vCONSULTAID",gxz:"ZV7ConsultaId",gxold:"OV7ConsultaId",gxvar:"AV7ConsultaId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7ConsultaId=gx.num.intval(a)
},v2z:function(a){gx.O.ZV7ConsultaId=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCONSULTAID",gx.O.AV7ConsultaId,0)},c2v:function(){gx.O.AV7ConsultaId=this.val()},val:function(){return gx.fn.getIntegerValue("vCONSULTAID",",")},nac:function(){return false}};this.GXValidFnc[21]={fld:"TEXTBLOCK3",format:0,grid:0};this.GXValidFnc[23]={lvl:0,type:"date",len:8,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCONSULTAFECHA",gxz:"ZV9ConsultaFecha",gxold:"OV9ConsultaFecha",gxvar:"AV9ConsultaFecha",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV9ConsultaFecha=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.ZV9ConsultaFecha=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setControlValue("vCONSULTAFECHA",gx.O.AV9ConsultaFecha,0)},c2v:function(){gx.O.AV9ConsultaFecha=this.val()},val:function(){return gx.fn.getControlValue("vCONSULTAFECHA")},nac:function(){return false}};this.GXValidFnc[25]={fld:"TEXTBLOCK4",format:0,grid:0};this.GXValidFnc[27]={lvl:0,type:"char",len:8,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCONSULTAHORA",gxz:"ZV10ConsultaHora",gxold:"OV10ConsultaHora",gxvar:"AV10ConsultaHora",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV10ConsultaHora=a
},v2z:function(a){gx.O.ZV10ConsultaHora=a},v2c:function(){gx.fn.setControlValue("vCONSULTAHORA",gx.O.AV10ConsultaHora,0)},c2v:function(){gx.O.AV10ConsultaHora=this.val()},val:function(){return gx.fn.getControlValue("vCONSULTAHORA")},nac:function(){return false}};this.GXValidFnc[30]={fld:"TABLE4",grid:0};this.GXValidFnc[33]={fld:"TEXTBLOCK5",format:0,grid:0};this.GXValidFnc[35]={lvl:0,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vPACIENTEID",gxz:"ZV8PacienteId",gxold:"OV8PacienteId",gxvar:"AV8PacienteId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV8PacienteId=gx.num.intval(a)
},v2z:function(a){gx.O.ZV8PacienteId=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vPACIENTEID",gx.O.AV8PacienteId,0)},c2v:function(){gx.O.AV8PacienteId=this.val()},val:function(){return gx.fn.getIntegerValue("vPACIENTEID",",")},nac:function(){return false}};this.GXValidFnc[37]={fld:"TEXTBLOCK16",format:0,grid:0};this.GXValidFnc[39]={lvl:0,type:"svchar",len:70,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vPACIENTENOMBRE1",gxz:"ZV11PacienteNombre1",gxold:"OV11PacienteNombre1",gxvar:"AV11PacienteNombre1",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV11PacienteNombre1=a
},v2z:function(a){gx.O.ZV11PacienteNombre1=a},v2c:function(){gx.fn.setControlValue("vPACIENTENOMBRE1",gx.O.AV11PacienteNombre1,0)},c2v:function(){gx.O.AV11PacienteNombre1=this.val()},val:function(){return gx.fn.getControlValue("vPACIENTENOMBRE1")},nac:function(){return false}};this.GXValidFnc[41]={fld:"TEXTBLOCK15",format:0,grid:0};this.GXValidFnc[43]={lvl:0,type:"svchar",len:70,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vPACIENTENOMBRE2",gxz:"ZV12PacienteNombre2",gxold:"OV12PacienteNombre2",gxvar:"AV12PacienteNombre2",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV12PacienteNombre2=a
},v2z:function(a){gx.O.ZV12PacienteNombre2=a},v2c:function(){gx.fn.setControlValue("vPACIENTENOMBRE2",gx.O.AV12PacienteNombre2,0)},c2v:function(){gx.O.AV12PacienteNombre2=this.val()},val:function(){return gx.fn.getControlValue("vPACIENTENOMBRE2")},nac:function(){return false}};this.GXValidFnc[46]={fld:"TEXTBLOCK12",format:0,grid:0};this.GXValidFnc[48]={lvl:0,type:"svchar",len:30,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vPACIENTEAPELLIDO1",gxz:"ZV13PacienteApellido1",gxold:"OV13PacienteApellido1",gxvar:"AV13PacienteApellido1",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV13PacienteApellido1=a
},v2z:function(a){gx.O.ZV13PacienteApellido1=a},v2c:function(){gx.fn.setControlValue("vPACIENTEAPELLIDO1",gx.O.AV13PacienteApellido1,0)},c2v:function(){gx.O.AV13PacienteApellido1=this.val()},val:function(){return gx.fn.getControlValue("vPACIENTEAPELLIDO1")},nac:function(){return false}};this.GXValidFnc[50]={fld:"TEXTBLOCK13",format:0,grid:0};this.GXValidFnc[52]={lvl:0,type:"svchar",len:30,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vPACIENTEAPELLIDO2",gxz:"ZV14PacienteApellido2",gxold:"OV14PacienteApellido2",gxvar:"AV14PacienteApellido2",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV14PacienteApellido2=a
},v2z:function(a){gx.O.ZV14PacienteApellido2=a},v2c:function(){gx.fn.setControlValue("vPACIENTEAPELLIDO2",gx.O.AV14PacienteApellido2,0)},c2v:function(){gx.O.AV14PacienteApellido2=this.val()},val:function(){return gx.fn.getControlValue("vPACIENTEAPELLIDO2")},nac:function(){return false}};this.GXValidFnc[54]={fld:"TEXTBLOCK14",format:0,grid:0};this.GXValidFnc[56]={lvl:0,type:"svchar",len:30,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vPACIENTEAPELLIDO3",gxz:"ZV15PacienteApellido3",gxold:"OV15PacienteApellido3",gxvar:"AV15PacienteApellido3",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV15PacienteApellido3=a
},v2z:function(a){gx.O.ZV15PacienteApellido3=a},v2c:function(){gx.fn.setControlValue("vPACIENTEAPELLIDO3",gx.O.AV15PacienteApellido3,0)},c2v:function(){gx.O.AV15PacienteApellido3=this.val()},val:function(){return gx.fn.getControlValue("vPACIENTEAPELLIDO3")},nac:function(){return false}};this.GXValidFnc[59]={fld:"TEXTBLOCK11",format:0,grid:0};this.GXValidFnc[61]={lvl:0,type:"date",len:8,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vPACIENTENACIMIENTO",gxz:"ZV16PacienteNacimiento",gxold:"OV16PacienteNacimiento",gxvar:"AV16PacienteNacimiento",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV16PacienteNacimiento=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.ZV16PacienteNacimiento=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setControlValue("vPACIENTENACIMIENTO",gx.O.AV16PacienteNacimiento,0)},c2v:function(){gx.O.AV16PacienteNacimiento=this.val()},val:function(){return gx.fn.getControlValue("vPACIENTENACIMIENTO")},nac:function(){return false}};this.GXValidFnc[63]={fld:"TEXTBLOCK10",format:0,grid:0};this.GXValidFnc[65]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vCONSULTAEDAD",gxz:"ZV18ConsultaEdad",gxold:"OV18ConsultaEdad",gxvar:"AV18ConsultaEdad",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV18ConsultaEdad=gx.num.intval(a)
},v2z:function(a){gx.O.ZV18ConsultaEdad=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCONSULTAEDAD",gx.O.AV18ConsultaEdad,0)},c2v:function(){gx.O.AV18ConsultaEdad=this.val()},val:function(){return gx.fn.getIntegerValue("vCONSULTAEDAD",",")},nac:function(){return false}};this.GXValidFnc[67]={fld:"TEXTBLOCK9",format:0,grid:0};this.GXValidFnc[69]={lvl:0,type:"svchar",len:1,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vPACIENTEGENERO",gxz:"ZV17PacienteGenero",gxold:"OV17PacienteGenero",gxvar:"AV17PacienteGenero",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.AV17PacienteGenero=a
},v2z:function(a){gx.O.ZV17PacienteGenero=a},v2c:function(){gx.fn.setComboBoxValue("vPACIENTEGENERO",gx.O.AV17PacienteGenero)},c2v:function(){gx.O.AV17PacienteGenero=this.val()},val:function(){return gx.fn.getControlValue("vPACIENTEGENERO")},nac:function(){return false}};this.GXValidFnc[72]={fld:"TABLE5",grid:0};this.GXValidFnc[75]={fld:"TEXTBLOCK8",format:0,grid:0};this.GXValidFnc[77]={lvl:0,type:"int",len:1,dec:0,sign:false,pic:"9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vCONSULTATIPO",gxz:"ZV19ConsultaTipo",gxold:"OV19ConsultaTipo",gxvar:"AV19ConsultaTipo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.AV19ConsultaTipo=gx.num.intval(a)
},v2z:function(a){gx.O.ZV19ConsultaTipo=gx.num.intval(a)},v2c:function(){gx.fn.setComboBoxValue("vCONSULTATIPO",gx.O.AV19ConsultaTipo)},c2v:function(){gx.O.AV19ConsultaTipo=this.val()},val:function(){return gx.fn.getIntegerValue("vCONSULTATIPO",",")},nac:function(){return false}};this.GXValidFnc[79]={fld:"TEXTBLOCK7",format:0,grid:0};this.GXValidFnc[81]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vASEGCODIGO",gxz:"ZV21AsegCodigo",gxold:"OV21AsegCodigo",gxvar:"AV21AsegCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.AV21AsegCodigo=a
},v2z:function(a){gx.O.ZV21AsegCodigo=a},v2c:function(){gx.fn.setComboBoxValue("vASEGCODIGO",gx.O.AV21AsegCodigo)},c2v:function(){gx.O.AV21AsegCodigo=this.val()},val:function(){return gx.fn.getControlValue("vASEGCODIGO")},nac:function(){return false}};this.GXValidFnc[83]={fld:"TEXTBLOCK6",format:0,grid:0};this.GXValidFnc[85]={lvl:0,type:"svchar",len:70,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCONSULTAPOLIZA",gxz:"ZV20ConsultaPoliza",gxold:"OV20ConsultaPoliza",gxvar:"AV20ConsultaPoliza",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV20ConsultaPoliza=a
},v2z:function(a){gx.O.ZV20ConsultaPoliza=a},v2c:function(){gx.fn.setControlValue("vCONSULTAPOLIZA",gx.O.AV20ConsultaPoliza,0)},c2v:function(){gx.O.AV20ConsultaPoliza=this.val()},val:function(){return gx.fn.getControlValue("vCONSULTAPOLIZA")},nac:function(){return false}};this.GXValidFnc[88]={fld:"TABLE8",grid:0};this.GXValidFnc[91]={fld:"TEXTBLOCK19",format:0,grid:0};this.GXValidFnc[93]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vMEDICOCODIGO",gxz:"ZV26MedicoCodigo",gxold:"OV26MedicoCodigo",gxvar:"AV26MedicoCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.AV26MedicoCodigo=a
},v2z:function(a){gx.O.ZV26MedicoCodigo=a},v2c:function(){gx.fn.setComboBoxValue("vMEDICOCODIGO",gx.O.AV26MedicoCodigo)},c2v:function(){gx.O.AV26MedicoCodigo=this.val()},val:function(){return gx.fn.getControlValue("vMEDICOCODIGO")},nac:function(){return false}};this.GXValidFnc[96]={fld:"TABLE7",grid:0};this.GXValidFnc[99]={fld:"TEXTBLOCK18",format:0,grid:0};this.GXValidFnc[101]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCIE10CODIGO",gxz:"ZV24Cie10Codigo",gxold:"OV24Cie10Codigo",gxvar:"AV24Cie10Codigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.AV24Cie10Codigo=a
},v2z:function(a){gx.O.ZV24Cie10Codigo=a},v2c:function(){gx.fn.setComboBoxValue("vCIE10CODIGO",gx.O.AV24Cie10Codigo)},c2v:function(){gx.O.AV24Cie10Codigo=this.val()},val:function(){return gx.fn.getControlValue("vCIE10CODIGO")},nac:function(){return false}};this.GXValidFnc[104]={fld:"TABLE6",grid:0};this.GXValidFnc[107]={fld:"TEXTBLOCK17",format:0,grid:0};this.GXValidFnc[109]={lvl:0,type:"svchar",len:600,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCONSULTAOBS",gxz:"ZV22ConsultaObs",gxold:"OV22ConsultaObs",gxvar:"AV22ConsultaObs",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV22ConsultaObs=a
},v2z:function(a){gx.O.ZV22ConsultaObs=a},v2c:function(){gx.fn.setControlValue("vCONSULTAOBS",gx.O.AV22ConsultaObs,0)},c2v:function(){gx.O.AV22ConsultaObs=this.val()},val:function(){return gx.fn.getControlValue("vCONSULTAOBS")},nac:function(){return false}};this.AV7ConsultaId=0;this.ZV7ConsultaId=0;this.OV7ConsultaId=0;this.AV9ConsultaFecha=gx.date.nullDate();this.ZV9ConsultaFecha=gx.date.nullDate();this.OV9ConsultaFecha=gx.date.nullDate();this.AV10ConsultaHora="";this.ZV10ConsultaHora="";this.OV10ConsultaHora="";
this.AV8PacienteId=0;this.ZV8PacienteId=0;this.OV8PacienteId=0;this.AV11PacienteNombre1="";this.ZV11PacienteNombre1="";this.OV11PacienteNombre1="";this.AV12PacienteNombre2="";this.ZV12PacienteNombre2="";this.OV12PacienteNombre2="";this.AV13PacienteApellido1="";this.ZV13PacienteApellido1="";this.OV13PacienteApellido1="";this.AV14PacienteApellido2="";this.ZV14PacienteApellido2="";this.OV14PacienteApellido2="";this.AV15PacienteApellido3="";this.ZV15PacienteApellido3="";this.OV15PacienteApellido3="";
this.AV16PacienteNacimiento=gx.date.nullDate();this.ZV16PacienteNacimiento=gx.date.nullDate();this.OV16PacienteNacimiento=gx.date.nullDate();this.AV18ConsultaEdad=0;this.ZV18ConsultaEdad=0;this.OV18ConsultaEdad=0;this.AV17PacienteGenero="";this.ZV17PacienteGenero="";this.OV17PacienteGenero="";this.AV19ConsultaTipo=0;this.ZV19ConsultaTipo=0;this.OV19ConsultaTipo=0;this.AV21AsegCodigo="";this.ZV21AsegCodigo="";this.OV21AsegCodigo="";this.AV20ConsultaPoliza="";this.ZV20ConsultaPoliza="";this.OV20ConsultaPoliza="";
this.AV26MedicoCodigo="";this.ZV26MedicoCodigo="";this.OV26MedicoCodigo="";this.AV24Cie10Codigo="";this.ZV24Cie10Codigo="";this.OV24Cie10Codigo="";this.AV22ConsultaObs="";this.ZV22ConsultaObs="";this.OV22ConsultaObs="";this.A41ClinicaCodigo="";this.A20MedicoNombre="";this.A19MedicoCodigo="";this.A51Cie10Descripcion="";this.A50Cie10Codigo="";this.A83AsegNombre="";this.A82AsegCodigo="";this.ServerEvents=["e121j2_client","e131j2_client","e141j2_client","e151j2_client","e161j2_client","e191j2_client","e201j2_client"];
this.SetStandaloneVars();this.setComponent({id:"WEBCOMP1",GXClass:null,Prefix:"W0120",lvl:1})}wp_registraconsulta.prototype=new gx.GxObject;gx.setParentObj(new wp_registraconsulta());