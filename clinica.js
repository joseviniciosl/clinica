gx.evt.autoSkip=false;function clinica(){this.ServerClass="Clinica";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=true;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Clinicacodigo=function(){gx.ajax.validSrvEvt("dyncall","Valid_Clinicacodigo",["gx.O.A41ClinicaCodigo","gx.O.A42ClinicaNombre","gx.O.A43ClinicaNit","gx.O.A44ClinicaTelefono1","gx.O.A45ClinicaTelefono2","gx.O.A46ClinicaCorreo","gx.O.A47ClinicaDireccion","gx.O.A48ClinicaZona","gx.O.A49ClinicaPropietario","gx.O.A53ClinicaLogo","gx.num.urlDecimal(gx.O.A206ClinicaIva,',','.')","gx.O.A35PaisCodigo","gx.O.A37DepCodigo","gx.O.A39MunCodigo"],["A42ClinicaNombre","A43ClinicaNit","A44ClinicaTelefono1","A45ClinicaTelefono2","A46ClinicaCorreo","A47ClinicaDireccion","A35PaisCodigo","A37DepCodigo","A39MunCodigo","A48ClinicaZona","A49ClinicaPropietario","A53ClinicaLogo","A206ClinicaIva","Gx_mode","Z41ClinicaCodigo","Z42ClinicaNombre","Z43ClinicaNit","Z44ClinicaTelefono1","Z45ClinicaTelefono2","Z46ClinicaCorreo","Z47ClinicaDireccion","Z35PaisCodigo","Z37DepCodigo","Z39MunCodigo","Z48ClinicaZona","Z49ClinicaPropietario","Z53ClinicaLogo","Z206ClinicaIva",["BTN_DELETE2","Enabled"],["BTN_ENTER2","Enabled"]]);
return true};this.Valid_Paiscodigo=function(){try{var a=gx.util.balloon.getNew("PAISCODIGO");this.AnyError=0}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Depcodigo=function(){try{var a=gx.util.balloon.getNew("DEPCODIGO");this.AnyError=0}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Muncodigo=function(){gx.ajax.validSrvEvt("dyncall","Valid_Muncodigo",["gx.O.A35PaisCodigo","gx.O.A37DepCodigo","gx.O.A39MunCodigo"],[]);
return true};this.e110b16_client=function(){this.executeServerEvent("ENTER",true)};this.e120b16_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[2,5,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,26,27,33,36,38,41,43,46,48,51,53,56,58,61,63,66,68,71,73,76,78,81,83,86,88,91,93,96,98,101,103,109];this.GXLastCtrlId=109;this.GXValidFnc[2]={fld:"TABLEMAIN",grid:0};this.GXValidFnc[5]={fld:"TABLETOOLBAR",grid:0};this.GXValidFnc[8]={fld:"BTN_FIRST",grid:0};this.GXValidFnc[9]={fld:"BTN_FIRST_SEPARATOR",grid:0};
this.GXValidFnc[10]={fld:"BTN_PREVIOUS",grid:0};this.GXValidFnc[11]={fld:"BTN_PREVIOUS_SEPARATOR",grid:0};this.GXValidFnc[12]={fld:"BTN_NEXT",grid:0};this.GXValidFnc[13]={fld:"BTN_NEXT_SEPARATOR",grid:0};this.GXValidFnc[14]={fld:"BTN_LAST",grid:0};this.GXValidFnc[15]={fld:"BTN_LAST_SEPARATOR",grid:0};this.GXValidFnc[16]={fld:"BTN_SELECT",grid:0};this.GXValidFnc[17]={fld:"BTN_SELECT_SEPARATOR",grid:0};this.GXValidFnc[18]={fld:"BTN_ENTER2",grid:0};this.GXValidFnc[19]={fld:"BTN_ENTER2_SEPARATOR",grid:0};
this.GXValidFnc[20]={fld:"BTN_CANCEL2",grid:0};this.GXValidFnc[21]={fld:"BTN_CANCEL2_SEPARATOR",grid:0};this.GXValidFnc[22]={fld:"BTN_DELETE2",grid:0};this.GXValidFnc[23]={fld:"BTN_DELETE2_SEPARATOR",grid:0};this.GXValidFnc[26]={fld:"GROUPDATA",grid:0};this.GXValidFnc[27]={fld:"TABLE1",grid:0};this.GXValidFnc[33]={fld:"TABLE2",grid:0};this.GXValidFnc[36]={fld:"TEXTBLOCKCLINICACODIGO",format:0,grid:0};this.GXValidFnc[38]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Clinicacodigo,isvalid:null,fld:"CLINICACODIGO",gxz:"Z41ClinicaCodigo",gxold:"O41ClinicaCodigo",gxvar:"A41ClinicaCodigo",ucs:[],op:[83,78,73,103,98,93,88,68,63,58,53,48,43],ip:[83,78,73,103,98,93,88,68,63,58,53,48,43,38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A41ClinicaCodigo=a
},v2z:function(a){gx.O.Z41ClinicaCodigo=a},v2c:function(){gx.fn.setControlValue("CLINICACODIGO",gx.O.A41ClinicaCodigo,0)},c2v:function(){gx.O.A41ClinicaCodigo=this.val()},val:function(){return gx.fn.getControlValue("CLINICACODIGO")},nac:function(){return false}};this.GXValidFnc[41]={fld:"TEXTBLOCKCLINICANOMBRE",format:0,grid:0};this.GXValidFnc[43]={lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"CLINICANOMBRE",gxz:"Z42ClinicaNombre",gxold:"O42ClinicaNombre",gxvar:"A42ClinicaNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A42ClinicaNombre=a
},v2z:function(a){gx.O.Z42ClinicaNombre=a},v2c:function(){gx.fn.setControlValue("CLINICANOMBRE",gx.O.A42ClinicaNombre,0)},c2v:function(){gx.O.A42ClinicaNombre=this.val()},val:function(){return gx.fn.getControlValue("CLINICANOMBRE")},nac:function(){return false}};this.GXValidFnc[46]={fld:"TEXTBLOCKCLINICANIT",format:0,grid:0};this.GXValidFnc[48]={lvl:0,type:"svchar",len:20,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"CLINICANIT",gxz:"Z43ClinicaNit",gxold:"O43ClinicaNit",gxvar:"A43ClinicaNit",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A43ClinicaNit=a
},v2z:function(a){gx.O.Z43ClinicaNit=a},v2c:function(){gx.fn.setControlValue("CLINICANIT",gx.O.A43ClinicaNit,0)},c2v:function(){gx.O.A43ClinicaNit=this.val()},val:function(){return gx.fn.getControlValue("CLINICANIT")},nac:function(){return false}};this.GXValidFnc[51]={fld:"TEXTBLOCKCLINICATELEFONO1",format:0,grid:0};this.GXValidFnc[53]={lvl:0,type:"svchar",len:9,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"CLINICATELEFONO1",gxz:"Z44ClinicaTelefono1",gxold:"O44ClinicaTelefono1",gxvar:"A44ClinicaTelefono1",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A44ClinicaTelefono1=a
},v2z:function(a){gx.O.Z44ClinicaTelefono1=a},v2c:function(){gx.fn.setControlValue("CLINICATELEFONO1",gx.O.A44ClinicaTelefono1,0)},c2v:function(){gx.O.A44ClinicaTelefono1=this.val()},val:function(){return gx.fn.getControlValue("CLINICATELEFONO1")},nac:function(){return false}};this.GXValidFnc[56]={fld:"TEXTBLOCKCLINICATELEFONO2",format:0,grid:0};this.GXValidFnc[58]={lvl:0,type:"svchar",len:9,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"CLINICATELEFONO2",gxz:"Z45ClinicaTelefono2",gxold:"O45ClinicaTelefono2",gxvar:"A45ClinicaTelefono2",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A45ClinicaTelefono2=a
},v2z:function(a){gx.O.Z45ClinicaTelefono2=a},v2c:function(){gx.fn.setControlValue("CLINICATELEFONO2",gx.O.A45ClinicaTelefono2,0)},c2v:function(){gx.O.A45ClinicaTelefono2=this.val()},val:function(){return gx.fn.getControlValue("CLINICATELEFONO2")},nac:function(){return false}};this.GXValidFnc[61]={fld:"TEXTBLOCKCLINICACORREO",format:0,grid:0};this.GXValidFnc[63]={lvl:0,type:"svchar",len:80,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"CLINICACORREO",gxz:"Z46ClinicaCorreo",gxold:"O46ClinicaCorreo",gxvar:"A46ClinicaCorreo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A46ClinicaCorreo=a
},v2z:function(a){gx.O.Z46ClinicaCorreo=a},v2c:function(){gx.fn.setControlValue("CLINICACORREO",gx.O.A46ClinicaCorreo,0)},c2v:function(){gx.O.A46ClinicaCorreo=this.val()},val:function(){return gx.fn.getControlValue("CLINICACORREO")},nac:function(){return false}};this.GXValidFnc[66]={fld:"TEXTBLOCKCLINICADIRECCION",format:0,grid:0};this.GXValidFnc[68]={lvl:0,type:"svchar",len:120,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"CLINICADIRECCION",gxz:"Z47ClinicaDireccion",gxold:"O47ClinicaDireccion",gxvar:"A47ClinicaDireccion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A47ClinicaDireccion=a
},v2z:function(a){gx.O.Z47ClinicaDireccion=a},v2c:function(){gx.fn.setControlValue("CLINICADIRECCION",gx.O.A47ClinicaDireccion,0)},c2v:function(){gx.O.A47ClinicaDireccion=this.val()},val:function(){return gx.fn.getControlValue("CLINICADIRECCION")},nac:function(){return false}};this.GXValidFnc[71]={fld:"TEXTBLOCKPAISCODIGO",format:0,grid:0};this.GXValidFnc[73]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Paiscodigo,isvalid:null,fld:"PAISCODIGO",gxz:"Z35PaisCodigo",gxold:"O35PaisCodigo",gxvar:"A35PaisCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A35PaisCodigo=a
},v2z:function(a){gx.O.Z35PaisCodigo=a},v2c:function(){gx.fn.setControlValue("PAISCODIGO",gx.O.A35PaisCodigo,0)},c2v:function(){gx.O.A35PaisCodigo=this.val()},val:function(){return gx.fn.getControlValue("PAISCODIGO")},nac:function(){return false}};this.GXValidFnc[76]={fld:"TEXTBLOCKDEPCODIGO",format:0,grid:0};this.GXValidFnc[78]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Depcodigo,isvalid:null,fld:"DEPCODIGO",gxz:"Z37DepCodigo",gxold:"O37DepCodigo",gxvar:"A37DepCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A37DepCodigo=a
},v2z:function(a){gx.O.Z37DepCodigo=a},v2c:function(){gx.fn.setControlValue("DEPCODIGO",gx.O.A37DepCodigo,0)},c2v:function(){gx.O.A37DepCodigo=this.val()},val:function(){return gx.fn.getControlValue("DEPCODIGO")},nac:function(){return false}};this.GXValidFnc[81]={fld:"TEXTBLOCKMUNCODIGO",format:0,grid:0};this.GXValidFnc[83]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Muncodigo,isvalid:null,fld:"MUNCODIGO",gxz:"Z39MunCodigo",gxold:"O39MunCodigo",gxvar:"A39MunCodigo",ucs:[],op:[],ip:[83,78,73],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A39MunCodigo=a
},v2z:function(a){gx.O.Z39MunCodigo=a},v2c:function(){gx.fn.setControlValue("MUNCODIGO",gx.O.A39MunCodigo,0)},c2v:function(){gx.O.A39MunCodigo=this.val()},val:function(){return gx.fn.getControlValue("MUNCODIGO")},nac:function(){return false}};this.GXValidFnc[86]={fld:"TEXTBLOCKCLINICAZONA",format:0,grid:0};this.GXValidFnc[88]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"CLINICAZONA",gxz:"Z48ClinicaZona",gxold:"O48ClinicaZona",gxvar:"A48ClinicaZona",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A48ClinicaZona=gx.num.intval(a)
},v2z:function(a){gx.O.Z48ClinicaZona=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("CLINICAZONA",gx.O.A48ClinicaZona,0)},c2v:function(){gx.O.A48ClinicaZona=this.val()},val:function(){return gx.fn.getIntegerValue("CLINICAZONA",",")},nac:function(){return false}};this.GXValidFnc[91]={fld:"TEXTBLOCKCLINICAPROPIETARIO",format:0,grid:0};this.GXValidFnc[93]={lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"CLINICAPROPIETARIO",gxz:"Z49ClinicaPropietario",gxold:"O49ClinicaPropietario",gxvar:"A49ClinicaPropietario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A49ClinicaPropietario=a
},v2z:function(a){gx.O.Z49ClinicaPropietario=a},v2c:function(){gx.fn.setControlValue("CLINICAPROPIETARIO",gx.O.A49ClinicaPropietario,0)},c2v:function(){gx.O.A49ClinicaPropietario=this.val()},val:function(){return gx.fn.getControlValue("CLINICAPROPIETARIO")},nac:function(){return false}};this.GXValidFnc[96]={fld:"TEXTBLOCKCLINICALOGO",format:0,grid:0};this.GXValidFnc[98]={lvl:0,type:"bitstr",len:1024,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"CLINICALOGO",gxz:"Z53ClinicaLogo",gxold:"O53ClinicaLogo",gxvar:"A53ClinicaLogo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A53ClinicaLogo=a
},v2z:function(a){gx.O.Z53ClinicaLogo=a},v2c:function(){gx.fn.setBlobValue("CLINICALOGO",gx.O.A53ClinicaLogo)},c2v:function(){gx.O.A53ClinicaLogo=this.val()},val:function(){return gx.fn.getBlobValue("CLINICALOGO")},nac:function(){return false}};this.GXValidFnc[101]={fld:"TEXTBLOCKCLINICAIVA",format:0,grid:0};this.GXValidFnc[103]={lvl:0,type:"decimal",len:17,dec:2,sign:false,pic:"ZZZZZZZZZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"CLINICAIVA",gxz:"Z206ClinicaIva",gxold:"O206ClinicaIva",gxvar:"A206ClinicaIva",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A206ClinicaIva=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.Z206ClinicaIva=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setDecimalValue("CLINICAIVA",gx.O.A206ClinicaIva,2,".")},c2v:function(){gx.O.A206ClinicaIva=this.val()},val:function(){return gx.fn.getDecimalValue("CLINICAIVA",",",".")},nac:function(){return false}};this.GXValidFnc[109]={fld:"PROMPT_35_37_39",grid:16};this.A41ClinicaCodigo="";this.Z41ClinicaCodigo="";this.O41ClinicaCodigo="";this.A42ClinicaNombre="";this.Z42ClinicaNombre="";this.O42ClinicaNombre="";this.A43ClinicaNit="";
this.Z43ClinicaNit="";this.O43ClinicaNit="";this.A44ClinicaTelefono1="";this.Z44ClinicaTelefono1="";this.O44ClinicaTelefono1="";this.A45ClinicaTelefono2="";this.Z45ClinicaTelefono2="";this.O45ClinicaTelefono2="";this.A46ClinicaCorreo="";this.Z46ClinicaCorreo="";this.O46ClinicaCorreo="";this.A47ClinicaDireccion="";this.Z47ClinicaDireccion="";this.O47ClinicaDireccion="";this.A35PaisCodigo="";this.Z35PaisCodigo="";this.O35PaisCodigo="";this.A37DepCodigo="";this.Z37DepCodigo="";this.O37DepCodigo="";this.A39MunCodigo="";
this.Z39MunCodigo="";this.O39MunCodigo="";this.A48ClinicaZona=0;this.Z48ClinicaZona=0;this.O48ClinicaZona=0;this.A49ClinicaPropietario="";this.Z49ClinicaPropietario="";this.O49ClinicaPropietario="";this.A53ClinicaLogo="";this.Z53ClinicaLogo="";this.O53ClinicaLogo="";this.A206ClinicaIva=0;this.Z206ClinicaIva=0;this.O206ClinicaIva=0;this.ServerEvents=["e110b16_client","e120b16_client"];this.setPrompt("PROMPT_35_37_39",[73,78,83]);this.EnterCtrl=["BTN_ENTER2","BTN_ENTER2_SEPARATOR","BTN_ENTER"];this.VarControlMap.Gx_mode={id:"vMODE",grid:0,type:"char"};
this.SetStandaloneVars()}clinica.prototype=new gx.GxObject;gx.setParentObj(new clinica());