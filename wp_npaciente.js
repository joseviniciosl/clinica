gx.evt.autoSkip=false;function wp_npaciente(){this.ServerClass="wp_npaciente";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=false;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV5ClinicaCodigo=gx.fn.getControlValue("vCLINICACODIGO")};this.e123h2_client=function(){this.executeServerEvent("'RETORNAR'",false)};this.e133h2_client=function(){this.executeServerEvent("'CONFIRMAR'",false)};this.e153h2_client=function(){this.executeServerEvent("ENTER",true)
};this.e163h2_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[2,5,11,14,16,18,20,23,25,27,29,32,34,36,38,41,43,48,51,53,55,57,60,61,63,64,66,68,71,74,76,79,81,84,86,89,91,94,96,99,102,104,107,109,112,114,117,119,122,125,127,129,131,134,136,138,140,143,145,147,149,152,154,156,158,161,164,166,169,172,175,177,180,182,185,187,190,192];this.GXLastCtrlId=192;this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[5]={fld:"TEXTBLOCK1",format:0,grid:0};this.GXValidFnc[11]={fld:"TABLE2",grid:0};
this.GXValidFnc[14]={fld:"TEXTBLOCK19",format:0,grid:0};this.GXValidFnc[16]={lvl:0,type:"svchar",len:70,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vNPACIENTENOMBRE1",gxz:"ZV10NPacienteNombre1",gxold:"OV10NPacienteNombre1",gxvar:"AV10NPacienteNombre1",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV10NPacienteNombre1=a},v2z:function(a){gx.O.ZV10NPacienteNombre1=a},v2c:function(){gx.fn.setControlValue("vNPACIENTENOMBRE1",gx.O.AV10NPacienteNombre1,0)},c2v:function(){gx.O.AV10NPacienteNombre1=this.val()
},val:function(){return gx.fn.getControlValue("vNPACIENTENOMBRE1")},nac:function(){return false}};this.GXValidFnc[18]={fld:"TEXTBLOCK18",format:0,grid:0};this.GXValidFnc[20]={lvl:0,type:"svchar",len:70,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vNPACIENTENOMBRE2",gxz:"ZV11NPacienteNombre2",gxold:"OV11NPacienteNombre2",gxvar:"AV11NPacienteNombre2",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV11NPacienteNombre2=a},v2z:function(a){gx.O.ZV11NPacienteNombre2=a
},v2c:function(){gx.fn.setControlValue("vNPACIENTENOMBRE2",gx.O.AV11NPacienteNombre2,0)},c2v:function(){gx.O.AV11NPacienteNombre2=this.val()},val:function(){return gx.fn.getControlValue("vNPACIENTENOMBRE2")},nac:function(){return false}};this.GXValidFnc[23]={fld:"TEXTBLOCK17",format:0,grid:0};this.GXValidFnc[25]={lvl:0,type:"svchar",len:30,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vNPACIENTEAPELLIDO1",gxz:"ZV12NPacienteApellido1",gxold:"OV12NPacienteApellido1",gxvar:"AV12NPacienteApellido1",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV12NPacienteApellido1=a
},v2z:function(a){gx.O.ZV12NPacienteApellido1=a},v2c:function(){gx.fn.setControlValue("vNPACIENTEAPELLIDO1",gx.O.AV12NPacienteApellido1,0)},c2v:function(){gx.O.AV12NPacienteApellido1=this.val()},val:function(){return gx.fn.getControlValue("vNPACIENTEAPELLIDO1")},nac:function(){return false}};this.GXValidFnc[27]={fld:"TEXTBLOCK16",format:0,grid:0};this.GXValidFnc[29]={lvl:0,type:"svchar",len:30,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vNPACIENTEAPELLIDO2",gxz:"ZV13NPacienteApellido2",gxold:"OV13NPacienteApellido2",gxvar:"AV13NPacienteApellido2",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV13NPacienteApellido2=a
},v2z:function(a){gx.O.ZV13NPacienteApellido2=a},v2c:function(){gx.fn.setControlValue("vNPACIENTEAPELLIDO2",gx.O.AV13NPacienteApellido2,0)},c2v:function(){gx.O.AV13NPacienteApellido2=this.val()},val:function(){return gx.fn.getControlValue("vNPACIENTEAPELLIDO2")},nac:function(){return false}};this.GXValidFnc[32]={fld:"TEXTBLOCK15",format:0,grid:0};this.GXValidFnc[34]={lvl:0,type:"svchar",len:30,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vNPACIENTEAPELLIDO3",gxz:"ZV14NPacienteApellido3",gxold:"OV14NPacienteApellido3",gxvar:"AV14NPacienteApellido3",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV14NPacienteApellido3=a
},v2z:function(a){gx.O.ZV14NPacienteApellido3=a},v2c:function(){gx.fn.setControlValue("vNPACIENTEAPELLIDO3",gx.O.AV14NPacienteApellido3,0)},c2v:function(){gx.O.AV14NPacienteApellido3=this.val()},val:function(){return gx.fn.getControlValue("vNPACIENTEAPELLIDO3")},nac:function(){return false}};this.GXValidFnc[36]={fld:"TEXTBLOCK14",format:0,grid:0};this.GXValidFnc[38]={lvl:0,type:"date",len:8,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vNPACIENTEFECHANAC",gxz:"ZV15NPacienteFechaNac",gxold:"OV15NPacienteFechaNac",gxvar:"AV15NPacienteFechaNac",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV15NPacienteFechaNac=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.ZV15NPacienteFechaNac=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setControlValue("vNPACIENTEFECHANAC",gx.O.AV15NPacienteFechaNac,0)},c2v:function(){gx.O.AV15NPacienteFechaNac=this.val()},val:function(){return gx.fn.getControlValue("vNPACIENTEFECHANAC")},nac:function(){return false}};this.GXValidFnc[41]={fld:"TEXTBLOCK20",format:0,grid:0};this.GXValidFnc[43]={lvl:0,type:"svchar",len:1,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vNPACIENTESEXO",gxz:"ZV22NPacienteSexo",gxold:"OV22NPacienteSexo",gxvar:"AV22NPacienteSexo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.AV22NPacienteSexo=a
},v2z:function(a){gx.O.ZV22NPacienteSexo=a},v2c:function(){gx.fn.setComboBoxValue("vNPACIENTESEXO",gx.O.AV22NPacienteSexo)},c2v:function(){gx.O.AV22NPacienteSexo=this.val()},val:function(){return gx.fn.getControlValue("vNPACIENTESEXO")},nac:function(){return false}};this.GXValidFnc[48]={fld:"TABLE3",grid:0};this.GXValidFnc[51]={fld:"TEXTBLOCK13",format:0,grid:0};this.GXValidFnc[53]={fld:"TEXTBLOCK12",format:0,grid:0};this.GXValidFnc[55]={fld:"TEXTBLOCK11",format:0,grid:0};this.GXValidFnc[57]={fld:"TEXTBLOCK10",format:0,grid:0};
this.GXValidFnc[60]={lvl:0,type:"decimal",len:17,dec:2,sign:false,pic:"ZZZZZZZZZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vNPACIENTEESTATURA",gxz:"ZV18NPacienteEstatura",gxold:"OV18NPacienteEstatura",gxvar:"AV18NPacienteEstatura",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV18NPacienteEstatura=gx.fn.toDecimalValue(a,",",".")},v2z:function(a){gx.O.ZV18NPacienteEstatura=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setDecimalValue("vNPACIENTEESTATURA",gx.O.AV18NPacienteEstatura,2,".")
},c2v:function(){gx.O.AV18NPacienteEstatura=this.val()},val:function(){return gx.fn.getDecimalValue("vNPACIENTEESTATURA",",",".")},nac:function(){return false}};this.GXValidFnc[61]={lvl:0,type:"svchar",len:2,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vNPACIENTEESTATURAEN",gxz:"ZV19NPacienteEstaturaEn",gxold:"OV19NPacienteEstaturaEn",gxvar:"AV19NPacienteEstaturaEn",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.AV19NPacienteEstaturaEn=a},v2z:function(a){gx.O.ZV19NPacienteEstaturaEn=a
},v2c:function(){gx.fn.setComboBoxValue("vNPACIENTEESTATURAEN",gx.O.AV19NPacienteEstaturaEn)},c2v:function(){gx.O.AV19NPacienteEstaturaEn=this.val()},val:function(){return gx.fn.getControlValue("vNPACIENTEESTATURAEN")},nac:function(){return false}};this.GXValidFnc[63]={lvl:0,type:"decimal",len:17,dec:2,sign:false,pic:"ZZZZZZZZZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vNPACIENTEPESO",gxz:"ZV16NPacientePeso",gxold:"OV16NPacientePeso",gxvar:"AV16NPacientePeso",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV16NPacientePeso=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.ZV16NPacientePeso=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setDecimalValue("vNPACIENTEPESO",gx.O.AV16NPacientePeso,2,".")},c2v:function(){gx.O.AV16NPacientePeso=this.val()},val:function(){return gx.fn.getDecimalValue("vNPACIENTEPESO",",",".")},nac:function(){return false}};this.GXValidFnc[64]={lvl:0,type:"svchar",len:2,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vNPACIENTEPESOEN",gxz:"ZV17NPacientePesoEn",gxold:"OV17NPacientePesoEn",gxvar:"AV17NPacientePesoEn",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.AV17NPacientePesoEn=a
},v2z:function(a){gx.O.ZV17NPacientePesoEn=a},v2c:function(){gx.fn.setComboBoxValue("vNPACIENTEPESOEN",gx.O.AV17NPacientePesoEn)},c2v:function(){gx.O.AV17NPacientePesoEn=this.val()},val:function(){return gx.fn.getControlValue("vNPACIENTEPESOEN")},nac:function(){return false}};this.GXValidFnc[66]={lvl:0,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vPROFESIONID",gxz:"ZV20ProfesionId",gxold:"OV20ProfesionId",gxvar:"AV20ProfesionId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"dyncombo",v2v:function(a){gx.O.AV20ProfesionId=gx.num.intval(a)
},v2z:function(a){gx.O.ZV20ProfesionId=gx.num.intval(a)},v2c:function(){gx.fn.setComboBoxValue("vPROFESIONID",gx.O.AV20ProfesionId)},c2v:function(){gx.O.AV20ProfesionId=this.val()},val:function(){return gx.fn.getIntegerValue("vPROFESIONID",",")},nac:function(){return false}};this.GXValidFnc[68]={lvl:0,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vRELIGIONID",gxz:"ZV21ReligionId",gxold:"OV21ReligionId",gxvar:"AV21ReligionId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"dyncombo",v2v:function(a){gx.O.AV21ReligionId=gx.num.intval(a)
},v2z:function(a){gx.O.ZV21ReligionId=gx.num.intval(a)},v2c:function(){gx.fn.setComboBoxValue("vRELIGIONID",gx.O.AV21ReligionId)},c2v:function(){gx.O.AV21ReligionId=this.val()},val:function(){return gx.fn.getIntegerValue("vRELIGIONID",",")},nac:function(){return false}};this.GXValidFnc[71]={fld:"TABLE4",grid:0};this.GXValidFnc[74]={fld:"TEXTBLOCK9",format:0,grid:0};this.GXValidFnc[76]={lvl:0,type:"svchar",len:120,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vNPACIENTEDIRECCION",gxz:"ZV23NPacienteDireccion",gxold:"OV23NPacienteDireccion",gxvar:"AV23NPacienteDireccion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV23NPacienteDireccion=a
},v2z:function(a){gx.O.ZV23NPacienteDireccion=a},v2c:function(){gx.fn.setControlValue("vNPACIENTEDIRECCION",gx.O.AV23NPacienteDireccion,0)},c2v:function(){gx.O.AV23NPacienteDireccion=this.val()},val:function(){return gx.fn.getControlValue("vNPACIENTEDIRECCION")},nac:function(){return false}};this.GXValidFnc[79]={fld:"TEXTBLOCK8",format:0,grid:0};this.GXValidFnc[81]={lvl:0,type:"svchar",len:80,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vNPACIENTECORREO",gxz:"ZV24NPacienteCorreo",gxold:"OV24NPacienteCorreo",gxvar:"AV24NPacienteCorreo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV24NPacienteCorreo=a
},v2z:function(a){gx.O.ZV24NPacienteCorreo=a},v2c:function(){gx.fn.setControlValue("vNPACIENTECORREO",gx.O.AV24NPacienteCorreo,0)},c2v:function(){gx.O.AV24NPacienteCorreo=this.val()},val:function(){return gx.fn.getControlValue("vNPACIENTECORREO")},nac:function(){return false}};this.GXValidFnc[84]={fld:"TEXTBLOCK7",format:0,grid:0};this.GXValidFnc[86]={lvl:0,type:"svchar",len:80,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vNPACIENTEFACEBOOK",gxz:"ZV25NPacienteFacebook",gxold:"OV25NPacienteFacebook",gxvar:"AV25NPacienteFacebook",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV25NPacienteFacebook=a
},v2z:function(a){gx.O.ZV25NPacienteFacebook=a},v2c:function(){gx.fn.setControlValue("vNPACIENTEFACEBOOK",gx.O.AV25NPacienteFacebook,0)},c2v:function(){gx.O.AV25NPacienteFacebook=this.val()},val:function(){return gx.fn.getControlValue("vNPACIENTEFACEBOOK")},nac:function(){return false}};this.GXValidFnc[89]={fld:"TEXTBLOCK6",format:0,grid:0};this.GXValidFnc[91]={lvl:0,type:"svchar",len:9,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vNPACIENTETELEFONO",gxz:"ZV26NPacienteTelefono",gxold:"OV26NPacienteTelefono",gxvar:"AV26NPacienteTelefono",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV26NPacienteTelefono=a
},v2z:function(a){gx.O.ZV26NPacienteTelefono=a},v2c:function(){gx.fn.setControlValue("vNPACIENTETELEFONO",gx.O.AV26NPacienteTelefono,0)},c2v:function(){gx.O.AV26NPacienteTelefono=this.val()},val:function(){return gx.fn.getControlValue("vNPACIENTETELEFONO")},nac:function(){return false}};this.GXValidFnc[94]={fld:"TEXTBLOCK5",format:0,grid:0};this.GXValidFnc[96]={lvl:0,type:"svchar",len:9,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vNPACIENTECELULAR",gxz:"ZV27NPacienteCelular",gxold:"OV27NPacienteCelular",gxvar:"AV27NPacienteCelular",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV27NPacienteCelular=a
},v2z:function(a){gx.O.ZV27NPacienteCelular=a},v2c:function(){gx.fn.setControlValue("vNPACIENTECELULAR",gx.O.AV27NPacienteCelular,0)},c2v:function(){gx.O.AV27NPacienteCelular=this.val()},val:function(){return gx.fn.getControlValue("vNPACIENTECELULAR")},nac:function(){return false}};this.GXValidFnc[99]={fld:"TABLE5",grid:0};this.GXValidFnc[102]={fld:"TEXTBLOCK30",format:0,grid:0};this.GXValidFnc[104]={lvl:0,type:"svchar",len:600,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vNPACIENTEENFERMEDAD",gxz:"ZV28NPacienteEnfermedad",gxold:"OV28NPacienteEnfermedad",gxvar:"AV28NPacienteEnfermedad",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV28NPacienteEnfermedad=a
},v2z:function(a){gx.O.ZV28NPacienteEnfermedad=a},v2c:function(){gx.fn.setControlValue("vNPACIENTEENFERMEDAD",gx.O.AV28NPacienteEnfermedad,0)},c2v:function(){gx.O.AV28NPacienteEnfermedad=this.val()},val:function(){return gx.fn.getControlValue("vNPACIENTEENFERMEDAD")},nac:function(){return false}};this.GXValidFnc[107]={fld:"TEXTBLOCK24",format:0,grid:0};this.GXValidFnc[109]={lvl:0,type:"svchar",len:600,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vNPACIENTEMEDICAMENTO",gxz:"ZV29NPacienteMedicamento",gxold:"OV29NPacienteMedicamento",gxvar:"AV29NPacienteMedicamento",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV29NPacienteMedicamento=a
},v2z:function(a){gx.O.ZV29NPacienteMedicamento=a},v2c:function(){gx.fn.setControlValue("vNPACIENTEMEDICAMENTO",gx.O.AV29NPacienteMedicamento,0)},c2v:function(){gx.O.AV29NPacienteMedicamento=this.val()},val:function(){return gx.fn.getControlValue("vNPACIENTEMEDICAMENTO")},nac:function(){return false}};this.GXValidFnc[112]={fld:"TEXTBLOCK29",format:0,grid:0};this.GXValidFnc[114]={lvl:0,type:"svchar",len:600,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vNPACIENTEOPERACION",gxz:"ZV30NPacienteOperacion",gxold:"OV30NPacienteOperacion",gxvar:"AV30NPacienteOperacion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV30NPacienteOperacion=a
},v2z:function(a){gx.O.ZV30NPacienteOperacion=a},v2c:function(){gx.fn.setControlValue("vNPACIENTEOPERACION",gx.O.AV30NPacienteOperacion,0)},c2v:function(){gx.O.AV30NPacienteOperacion=this.val()},val:function(){return gx.fn.getControlValue("vNPACIENTEOPERACION")},nac:function(){return false}};this.GXValidFnc[117]={fld:"TEXTBLOCK23",format:0,grid:0};this.GXValidFnc[119]={lvl:0,type:"svchar",len:600,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vNPACIENTEALERGIA",gxz:"ZV31NPacienteAlergia",gxold:"OV31NPacienteAlergia",gxvar:"AV31NPacienteAlergia",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV31NPacienteAlergia=a
},v2z:function(a){gx.O.ZV31NPacienteAlergia=a},v2c:function(){gx.fn.setControlValue("vNPACIENTEALERGIA",gx.O.AV31NPacienteAlergia,0)},c2v:function(){gx.O.AV31NPacienteAlergia=this.val()},val:function(){return gx.fn.getControlValue("vNPACIENTEALERGIA")},nac:function(){return false}};this.GXValidFnc[122]={fld:"TABLE6",grid:0};this.GXValidFnc[125]={fld:"TEXTBLOCK28",format:0,grid:0};this.GXValidFnc[127]={fld:"TEXTBLOCK27",format:0,grid:0};this.GXValidFnc[129]={fld:"TEXTBLOCK25",format:0,grid:0};this.GXValidFnc[131]={fld:"TEXTBLOCK26",format:0,grid:0};
this.GXValidFnc[134]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vNPACIENTEGESTA",gxz:"ZV33NPacienteGesta",gxold:"OV33NPacienteGesta",gxvar:"AV33NPacienteGesta",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV33NPacienteGesta=gx.num.intval(a)},v2z:function(a){gx.O.ZV33NPacienteGesta=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vNPACIENTEGESTA",gx.O.AV33NPacienteGesta,0)},c2v:function(){gx.O.AV33NPacienteGesta=this.val()
},val:function(){return gx.fn.getIntegerValue("vNPACIENTEGESTA",",")},nac:function(){return false}};this.GXValidFnc[136]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vNPACIENTEPARTO",gxz:"ZV32NPacienteParto",gxold:"OV32NPacienteParto",gxvar:"AV32NPacienteParto",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV32NPacienteParto=gx.num.intval(a)},v2z:function(a){gx.O.ZV32NPacienteParto=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vNPACIENTEPARTO",gx.O.AV32NPacienteParto,0)
},c2v:function(){gx.O.AV32NPacienteParto=this.val()},val:function(){return gx.fn.getIntegerValue("vNPACIENTEPARTO",",")},nac:function(){return false}};this.GXValidFnc[138]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vNPACIENTECESAREA",gxz:"ZV34NPacienteCesarea",gxold:"OV34NPacienteCesarea",gxvar:"AV34NPacienteCesarea",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV34NPacienteCesarea=gx.num.intval(a)},v2z:function(a){gx.O.ZV34NPacienteCesarea=gx.num.intval(a)
},v2c:function(){gx.fn.setControlValue("vNPACIENTECESAREA",gx.O.AV34NPacienteCesarea,0)},c2v:function(){gx.O.AV34NPacienteCesarea=this.val()},val:function(){return gx.fn.getIntegerValue("vNPACIENTECESAREA",",")},nac:function(){return false}};this.GXValidFnc[140]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vNPACIENTEABORTO",gxz:"ZV35NPacienteAborto",gxold:"OV35NPacienteAborto",gxvar:"AV35NPacienteAborto",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV35NPacienteAborto=gx.num.intval(a)
},v2z:function(a){gx.O.ZV35NPacienteAborto=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vNPACIENTEABORTO",gx.O.AV35NPacienteAborto,0)},c2v:function(){gx.O.AV35NPacienteAborto=this.val()},val:function(){return gx.fn.getIntegerValue("vNPACIENTEABORTO",",")},nac:function(){return false}};this.GXValidFnc[143]={fld:"TEXTBLOCK22",format:0,grid:0};this.GXValidFnc[145]={fld:"TEXTBLOCK21",format:0,grid:0};this.GXValidFnc[147]={fld:"TEXTBLOCK4",format:0,grid:0};this.GXValidFnc[149]={fld:"TEXTBLOCK42",format:0,grid:0};
this.GXValidFnc[152]={lvl:0,type:"int",len:1,dec:0,sign:false,pic:"9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vNPACIENTEANESTESIAGENERAL",gxz:"ZV36NPacienteAnestesiaGeneral",gxold:"OV36NPacienteAnestesiaGeneral",gxvar:"AV36NPacienteAnestesiaGeneral",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",v2v:function(a){gx.O.AV36NPacienteAnestesiaGeneral=gx.num.intval(a)},v2z:function(a){gx.O.ZV36NPacienteAnestesiaGeneral=gx.num.intval(a)},v2c:function(){gx.fn.setCheckBoxValue("vNPACIENTEANESTESIAGENERAL",gx.O.AV36NPacienteAnestesiaGeneral,"1")
},c2v:function(){gx.O.AV36NPacienteAnestesiaGeneral=this.val()},val:function(){return gx.fn.getCheckBoxValue("vNPACIENTEANESTESIAGENERAL","1","0")},nac:function(){return false}};this.GXValidFnc[154]={lvl:0,type:"int",len:1,dec:0,sign:false,pic:"9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vNPACIENTEANESTESIAEPIDURAL",gxz:"ZV37NPacienteAnestesiaEpidural",gxold:"OV37NPacienteAnestesiaEpidural",gxvar:"AV37NPacienteAnestesiaEpidural",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",v2v:function(a){gx.O.AV37NPacienteAnestesiaEpidural=gx.num.intval(a)
},v2z:function(a){gx.O.ZV37NPacienteAnestesiaEpidural=gx.num.intval(a)},v2c:function(){gx.fn.setCheckBoxValue("vNPACIENTEANESTESIAEPIDURAL",gx.O.AV37NPacienteAnestesiaEpidural,"1")},c2v:function(){gx.O.AV37NPacienteAnestesiaEpidural=this.val()},val:function(){return gx.fn.getCheckBoxValue("vNPACIENTEANESTESIAEPIDURAL","1","0")},nac:function(){return false}};this.GXValidFnc[156]={lvl:0,type:"int",len:1,dec:0,sign:false,pic:"9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vNPACIENTEANESTESIARAQUIDEA",gxz:"ZV38NPacienteAnestesiaRaquidea",gxold:"OV38NPacienteAnestesiaRaquidea",gxvar:"AV38NPacienteAnestesiaRaquidea",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",v2v:function(a){gx.O.AV38NPacienteAnestesiaRaquidea=gx.num.intval(a)
},v2z:function(a){gx.O.ZV38NPacienteAnestesiaRaquidea=gx.num.intval(a)},v2c:function(){gx.fn.setCheckBoxValue("vNPACIENTEANESTESIARAQUIDEA",gx.O.AV38NPacienteAnestesiaRaquidea,"1")},c2v:function(){gx.O.AV38NPacienteAnestesiaRaquidea=this.val()},val:function(){return gx.fn.getCheckBoxValue("vNPACIENTEANESTESIARAQUIDEA","1","0")},nac:function(){return false}};this.GXValidFnc[158]={lvl:0,type:"svchar",len:70,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vNPACIENTEANESTESIAOTRO",gxz:"ZV39NPacienteAnestesiaOtro",gxold:"OV39NPacienteAnestesiaOtro",gxvar:"AV39NPacienteAnestesiaOtro",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV39NPacienteAnestesiaOtro=a
},v2z:function(a){gx.O.ZV39NPacienteAnestesiaOtro=a},v2c:function(){gx.fn.setControlValue("vNPACIENTEANESTESIAOTRO",gx.O.AV39NPacienteAnestesiaOtro,0)},c2v:function(){gx.O.AV39NPacienteAnestesiaOtro=this.val()},val:function(){return gx.fn.getControlValue("vNPACIENTEANESTESIAOTRO")},nac:function(){return false}};this.GXValidFnc[161]={fld:"TABLE7",grid:0};this.GXValidFnc[164]={fld:"TEXTBLOCK41",format:0,grid:0};this.GXValidFnc[166]={lvl:0,type:"svchar",len:600,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vNPACIENTEANESTESIACOMPLICA",gxz:"ZV40NPacienteAnestesiaComplica",gxold:"OV40NPacienteAnestesiaComplica",gxvar:"AV40NPacienteAnestesiaComplica",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV40NPacienteAnestesiaComplica=a
},v2z:function(a){gx.O.ZV40NPacienteAnestesiaComplica=a},v2c:function(){gx.fn.setControlValue("vNPACIENTEANESTESIACOMPLICA",gx.O.AV40NPacienteAnestesiaComplica,0)},c2v:function(){gx.O.AV40NPacienteAnestesiaComplica=this.val()},val:function(){return gx.fn.getControlValue("vNPACIENTEANESTESIACOMPLICA")},nac:function(){return false}};this.GXValidFnc[169]={fld:"TABLE8",grid:0};this.GXValidFnc[172]={fld:"TABLE9",grid:0};this.GXValidFnc[175]={fld:"TEXTBLOCK34",format:0,grid:0};this.GXValidFnc[177]={lvl:0,type:"int",len:1,dec:0,sign:false,pic:"9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vNPACIENTEFUMA",gxz:"ZV41NPacienteFuma",gxold:"OV41NPacienteFuma",gxvar:"AV41NPacienteFuma",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",v2v:function(a){gx.O.AV41NPacienteFuma=gx.num.intval(a)
},v2z:function(a){gx.O.ZV41NPacienteFuma=gx.num.intval(a)},v2c:function(){gx.fn.setCheckBoxValue("vNPACIENTEFUMA",gx.O.AV41NPacienteFuma,"1")},c2v:function(){gx.O.AV41NPacienteFuma=this.val()},val:function(){return gx.fn.getCheckBoxValue("vNPACIENTEFUMA","1","0")},nac:function(){return false}};this.GXValidFnc[180]={fld:"TEXTBLOCK35",format:0,grid:0};this.GXValidFnc[182]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vNPACIENTECIGARROS",gxz:"ZV42NPacienteCigarros",gxold:"OV42NPacienteCigarros",gxvar:"AV42NPacienteCigarros",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV42NPacienteCigarros=gx.num.intval(a)
},v2z:function(a){gx.O.ZV42NPacienteCigarros=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vNPACIENTECIGARROS",gx.O.AV42NPacienteCigarros,0)},c2v:function(){gx.O.AV42NPacienteCigarros=this.val()},val:function(){return gx.fn.getIntegerValue("vNPACIENTECIGARROS",",")},nac:function(){return false}};this.GXValidFnc[185]={fld:"TEXTBLOCK36",format:0,grid:0};this.GXValidFnc[187]={lvl:0,type:"int",len:1,dec:0,sign:false,pic:"9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vNPACIENTEALCOHOL",gxz:"ZV43NPacienteAlcohol",gxold:"OV43NPacienteAlcohol",gxvar:"AV43NPacienteAlcohol",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",v2v:function(a){gx.O.AV43NPacienteAlcohol=gx.num.intval(a)
},v2z:function(a){gx.O.ZV43NPacienteAlcohol=gx.num.intval(a)},v2c:function(){gx.fn.setCheckBoxValue("vNPACIENTEALCOHOL",gx.O.AV43NPacienteAlcohol,"1")},c2v:function(){gx.O.AV43NPacienteAlcohol=this.val()},val:function(){return gx.fn.getCheckBoxValue("vNPACIENTEALCOHOL","1","0")},nac:function(){return false}};this.GXValidFnc[190]={fld:"TEXTBLOCK40",format:0,grid:0};this.GXValidFnc[192]={lvl:0,type:"svchar",len:70,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vNPACIENTEOTROS",gxz:"ZV44NPacienteOtros",gxold:"OV44NPacienteOtros",gxvar:"AV44NPacienteOtros",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV44NPacienteOtros=a
},v2z:function(a){gx.O.ZV44NPacienteOtros=a},v2c:function(){gx.fn.setControlValue("vNPACIENTEOTROS",gx.O.AV44NPacienteOtros,0)},c2v:function(){gx.O.AV44NPacienteOtros=this.val()},val:function(){return gx.fn.getControlValue("vNPACIENTEOTROS")},nac:function(){return false}};this.AV10NPacienteNombre1="";this.ZV10NPacienteNombre1="";this.OV10NPacienteNombre1="";this.AV11NPacienteNombre2="";this.ZV11NPacienteNombre2="";this.OV11NPacienteNombre2="";this.AV12NPacienteApellido1="";this.ZV12NPacienteApellido1="";
this.OV12NPacienteApellido1="";this.AV13NPacienteApellido2="";this.ZV13NPacienteApellido2="";this.OV13NPacienteApellido2="";this.AV14NPacienteApellido3="";this.ZV14NPacienteApellido3="";this.OV14NPacienteApellido3="";this.AV15NPacienteFechaNac=gx.date.nullDate();this.ZV15NPacienteFechaNac=gx.date.nullDate();this.OV15NPacienteFechaNac=gx.date.nullDate();this.AV22NPacienteSexo="";this.ZV22NPacienteSexo="";this.OV22NPacienteSexo="";this.AV18NPacienteEstatura=0;this.ZV18NPacienteEstatura=0;this.OV18NPacienteEstatura=0;
this.AV19NPacienteEstaturaEn="";this.ZV19NPacienteEstaturaEn="";this.OV19NPacienteEstaturaEn="";this.AV16NPacientePeso=0;this.ZV16NPacientePeso=0;this.OV16NPacientePeso=0;this.AV17NPacientePesoEn="";this.ZV17NPacientePesoEn="";this.OV17NPacientePesoEn="";this.AV20ProfesionId=0;this.ZV20ProfesionId=0;this.OV20ProfesionId=0;this.AV21ReligionId=0;this.ZV21ReligionId=0;this.OV21ReligionId=0;this.AV23NPacienteDireccion="";this.ZV23NPacienteDireccion="";this.OV23NPacienteDireccion="";this.AV24NPacienteCorreo="";
this.ZV24NPacienteCorreo="";this.OV24NPacienteCorreo="";this.AV25NPacienteFacebook="";this.ZV25NPacienteFacebook="";this.OV25NPacienteFacebook="";this.AV26NPacienteTelefono="";this.ZV26NPacienteTelefono="";this.OV26NPacienteTelefono="";this.AV27NPacienteCelular="";this.ZV27NPacienteCelular="";this.OV27NPacienteCelular="";this.AV28NPacienteEnfermedad="";this.ZV28NPacienteEnfermedad="";this.OV28NPacienteEnfermedad="";this.AV29NPacienteMedicamento="";this.ZV29NPacienteMedicamento="";this.OV29NPacienteMedicamento="";
this.AV30NPacienteOperacion="";this.ZV30NPacienteOperacion="";this.OV30NPacienteOperacion="";this.AV31NPacienteAlergia="";this.ZV31NPacienteAlergia="";this.OV31NPacienteAlergia="";this.AV33NPacienteGesta=0;this.ZV33NPacienteGesta=0;this.OV33NPacienteGesta=0;this.AV32NPacienteParto=0;this.ZV32NPacienteParto=0;this.OV32NPacienteParto=0;this.AV34NPacienteCesarea=0;this.ZV34NPacienteCesarea=0;this.OV34NPacienteCesarea=0;this.AV35NPacienteAborto=0;this.ZV35NPacienteAborto=0;this.OV35NPacienteAborto=0;
this.AV36NPacienteAnestesiaGeneral=0;this.ZV36NPacienteAnestesiaGeneral=0;this.OV36NPacienteAnestesiaGeneral=0;this.AV37NPacienteAnestesiaEpidural=0;this.ZV37NPacienteAnestesiaEpidural=0;this.OV37NPacienteAnestesiaEpidural=0;this.AV38NPacienteAnestesiaRaquidea=0;this.ZV38NPacienteAnestesiaRaquidea=0;this.OV38NPacienteAnestesiaRaquidea=0;this.AV39NPacienteAnestesiaOtro="";this.ZV39NPacienteAnestesiaOtro="";this.OV39NPacienteAnestesiaOtro="";this.AV40NPacienteAnestesiaComplica="";this.ZV40NPacienteAnestesiaComplica="";
this.OV40NPacienteAnestesiaComplica="";this.AV41NPacienteFuma=0;this.ZV41NPacienteFuma=0;this.OV41NPacienteFuma=0;this.AV42NPacienteCigarros=0;this.ZV42NPacienteCigarros=0;this.OV42NPacienteCigarros=0;this.AV43NPacienteAlcohol=0;this.ZV43NPacienteAlcohol=0;this.OV43NPacienteAlcohol=0;this.AV44NPacienteOtros="";this.ZV44NPacienteOtros="";this.OV44NPacienteOtros="";this.ServerEvents=["e123h2_client","e133h2_client","e153h2_client","e163h2_client"];this.VarControlMap.AV5ClinicaCodigo={id:"vCLINICACODIGO",grid:0,type:"svchar"};
this.SetStandaloneVars()}wp_npaciente.prototype=new gx.GxObject;gx.setParentObj(new wp_npaciente());