gx.evt.autoSkip=false;function cargo(){this.ServerClass="Cargo";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=true;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Clinicacodigo=function(){try{var a=gx.util.balloon.getNew("CLINICACODIGO");this.AnyError=0}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Consultaid=function(){gx.ajax.validSrvEvt("dyncall","Valid_Consultaid",["gx.O.A41ClinicaCodigo","gx.O.A91ConsultaId"],[]);
return true};this.Valid_Cargoid=function(){gx.ajax.validSrvEvt("dyncall","Valid_Cargoid",["gx.O.A41ClinicaCodigo","gx.O.A91ConsultaId","gx.O.A162CargoId","gx.num.urlDecimal(gx.O.A163CargoPrecio,',','.')","gx.num.urlDecimal(gx.O.A164CargoCantidad,',','.')","gx.O.A166CargoEstado","gx.O.A30ArticuloCodigo"],["A30ArticuloCodigo","A163CargoPrecio","A164CargoCantidad","A166CargoEstado","A165CargoTotal","Gx_mode","Z41ClinicaCodigo","Z91ConsultaId","Z162CargoId","Z30ArticuloCodigo","Z163CargoPrecio","Z164CargoCantidad","Z166CargoEstado","Z165CargoTotal",["BTN_DELETE2","Enabled"],["BTN_ENTER2","Enabled"]]);
return true};this.Valid_Articulocodigo=function(){gx.ajax.validSrvEvt("dyncall","Valid_Articulocodigo",["gx.O.A41ClinicaCodigo","gx.O.A30ArticuloCodigo"],[]);return true};this.Valid_Cargoprecio=function(){try{var a=gx.util.balloon.getNew("CARGOPRECIO");this.AnyError=0}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Cargocantidad=function(){try{var a=gx.util.balloon.getNew("CARGOCANTIDAD");this.AnyError=0;try{this.A165CargoTotal=gx.num.multiply(this.A163CargoPrecio,this.A164CargoCantidad)
}catch(b){}}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.e110z45_client=function(){this.executeServerEvent("ENTER",true)};this.e120z45_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[2,5,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,26,27,33,36,38,41,43,46,48,51,53,56,58,61,63,66,68,71,73,79,80];this.GXLastCtrlId=80;this.GXValidFnc[2]={fld:"TABLEMAIN",grid:0};this.GXValidFnc[5]={fld:"TABLETOOLBAR",grid:0};this.GXValidFnc[8]={fld:"BTN_FIRST",grid:0};
this.GXValidFnc[9]={fld:"BTN_FIRST_SEPARATOR",grid:0};this.GXValidFnc[10]={fld:"BTN_PREVIOUS",grid:0};this.GXValidFnc[11]={fld:"BTN_PREVIOUS_SEPARATOR",grid:0};this.GXValidFnc[12]={fld:"BTN_NEXT",grid:0};this.GXValidFnc[13]={fld:"BTN_NEXT_SEPARATOR",grid:0};this.GXValidFnc[14]={fld:"BTN_LAST",grid:0};this.GXValidFnc[15]={fld:"BTN_LAST_SEPARATOR",grid:0};this.GXValidFnc[16]={fld:"BTN_SELECT",grid:0};this.GXValidFnc[17]={fld:"BTN_SELECT_SEPARATOR",grid:0};this.GXValidFnc[18]={fld:"BTN_ENTER2",grid:0};
this.GXValidFnc[19]={fld:"BTN_ENTER2_SEPARATOR",grid:0};this.GXValidFnc[20]={fld:"BTN_CANCEL2",grid:0};this.GXValidFnc[21]={fld:"BTN_CANCEL2_SEPARATOR",grid:0};this.GXValidFnc[22]={fld:"BTN_DELETE2",grid:0};this.GXValidFnc[23]={fld:"BTN_DELETE2_SEPARATOR",grid:0};this.GXValidFnc[26]={fld:"GROUPDATA",grid:0};this.GXValidFnc[27]={fld:"TABLE1",grid:0};this.GXValidFnc[33]={fld:"TABLE2",grid:0};this.GXValidFnc[36]={fld:"TEXTBLOCKCLINICACODIGO",format:0,grid:0};this.GXValidFnc[38]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Clinicacodigo,isvalid:null,fld:"CLINICACODIGO",gxz:"Z41ClinicaCodigo",gxold:"O41ClinicaCodigo",gxvar:"A41ClinicaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A41ClinicaCodigo=a
},v2z:function(a){gx.O.Z41ClinicaCodigo=a},v2c:function(){gx.fn.setControlValue("CLINICACODIGO",gx.O.A41ClinicaCodigo,0)},c2v:function(){gx.O.A41ClinicaCodigo=this.val()},val:function(){return gx.fn.getControlValue("CLINICACODIGO")},nac:function(){return false}};this.GXValidFnc[41]={fld:"TEXTBLOCKCONSULTAID",format:0,grid:0};this.GXValidFnc[43]={lvl:0,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Consultaid,isvalid:null,rgrid:[],fld:"CONSULTAID",gxz:"Z91ConsultaId",gxold:"O91ConsultaId",gxvar:"A91ConsultaId",ucs:[],op:[],ip:[43,38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A91ConsultaId=gx.num.intval(a)
},v2z:function(a){gx.O.Z91ConsultaId=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("CONSULTAID",gx.O.A91ConsultaId,0)},c2v:function(){gx.O.A91ConsultaId=this.val()},val:function(){return gx.fn.getIntegerValue("CONSULTAID",",")},nac:function(){return false}};this.GXValidFnc[46]={fld:"TEXTBLOCKCARGOID",format:0,grid:0};this.GXValidFnc[48]={lvl:0,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Cargoid,isvalid:null,rgrid:[],fld:"CARGOID",gxz:"Z162CargoId",gxold:"O162CargoId",gxvar:"A162CargoId",ucs:[],op:[53,73,63,58],ip:[53,73,63,58,48,43,38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A162CargoId=gx.num.intval(a)
},v2z:function(a){gx.O.Z162CargoId=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("CARGOID",gx.O.A162CargoId,0)},c2v:function(){gx.O.A162CargoId=this.val()},val:function(){return gx.fn.getIntegerValue("CARGOID",",")},nac:function(){return false}};this.GXValidFnc[51]={fld:"TEXTBLOCKARTICULOCODIGO",format:0,grid:0};this.GXValidFnc[53]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Articulocodigo,isvalid:null,fld:"ARTICULOCODIGO",gxz:"Z30ArticuloCodigo",gxold:"O30ArticuloCodigo",gxvar:"A30ArticuloCodigo",ucs:[],op:[],ip:[53,38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A30ArticuloCodigo=a
},v2z:function(a){gx.O.Z30ArticuloCodigo=a},v2c:function(){gx.fn.setControlValue("ARTICULOCODIGO",gx.O.A30ArticuloCodigo,0)},c2v:function(){gx.O.A30ArticuloCodigo=this.val()},val:function(){return gx.fn.getControlValue("ARTICULOCODIGO")},nac:function(){return false}};this.GXValidFnc[56]={fld:"TEXTBLOCKCARGOPRECIO",format:0,grid:0};this.GXValidFnc[58]={lvl:0,type:"decimal",len:17,dec:2,sign:false,pic:"ZZZZZZZZZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Cargoprecio,isvalid:null,rgrid:[],fld:"CARGOPRECIO",gxz:"Z163CargoPrecio",gxold:"O163CargoPrecio",gxvar:"A163CargoPrecio",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A163CargoPrecio=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.Z163CargoPrecio=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setDecimalValue("CARGOPRECIO",gx.O.A163CargoPrecio,2,".")},c2v:function(){gx.O.A163CargoPrecio=this.val()},val:function(){return gx.fn.getDecimalValue("CARGOPRECIO",",",".")},nac:function(){return false}};this.GXValidFnc[61]={fld:"TEXTBLOCKCARGOCANTIDAD",format:0,grid:0};this.GXValidFnc[63]={lvl:0,type:"decimal",len:17,dec:2,sign:false,pic:"ZZZZZZZZZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Cargocantidad,isvalid:null,rgrid:[],fld:"CARGOCANTIDAD",gxz:"Z164CargoCantidad",gxold:"O164CargoCantidad",gxvar:"A164CargoCantidad",ucs:[],op:[68],ip:[68,63,58],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A164CargoCantidad=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.Z164CargoCantidad=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setDecimalValue("CARGOCANTIDAD",gx.O.A164CargoCantidad,2,".")},c2v:function(){gx.O.A164CargoCantidad=this.val()},val:function(){return gx.fn.getDecimalValue("CARGOCANTIDAD",",",".")},nac:function(){return false}};this.GXValidFnc[66]={fld:"TEXTBLOCKCARGOTOTAL",format:0,grid:0};this.GXValidFnc[68]={lvl:0,type:"decimal",len:17,dec:2,sign:false,pic:"ZZZZZZZZZZZZZ9.99",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"CARGOTOTAL",gxz:"Z165CargoTotal",gxold:"O165CargoTotal",gxvar:"A165CargoTotal",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A165CargoTotal=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.Z165CargoTotal=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setDecimalValue("CARGOTOTAL",gx.O.A165CargoTotal,2,".")},c2v:function(){gx.O.A165CargoTotal=this.val()},val:function(){return gx.fn.getDecimalValue("CARGOTOTAL",",",".")},nac:function(){return false}};this.GXValidFnc[71]={fld:"TEXTBLOCKCARGOESTADO",format:0,grid:0};this.GXValidFnc[73]={lvl:0,type:"int",len:1,dec:0,sign:false,pic:"9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"CARGOESTADO",gxz:"Z166CargoEstado",gxold:"O166CargoEstado",gxvar:"A166CargoEstado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.A166CargoEstado=gx.num.intval(a)
},v2z:function(a){gx.O.Z166CargoEstado=gx.num.intval(a)},v2c:function(){gx.fn.setComboBoxValue("CARGOESTADO",gx.O.A166CargoEstado)},c2v:function(){gx.O.A166CargoEstado=this.val()},val:function(){return gx.fn.getIntegerValue("CARGOESTADO",",")},nac:function(){return false}};this.GXValidFnc[79]={fld:"PROMPT_41_91",grid:45};this.GXValidFnc[80]={fld:"PROMPT_41_30",grid:45};this.A41ClinicaCodigo="";this.Z41ClinicaCodigo="";this.O41ClinicaCodigo="";this.A91ConsultaId=0;this.Z91ConsultaId=0;this.O91ConsultaId=0;
this.A162CargoId=0;this.Z162CargoId=0;this.O162CargoId=0;this.A30ArticuloCodigo="";this.Z30ArticuloCodigo="";this.O30ArticuloCodigo="";this.A163CargoPrecio=0;this.Z163CargoPrecio=0;this.O163CargoPrecio=0;this.A164CargoCantidad=0;this.Z164CargoCantidad=0;this.O164CargoCantidad=0;this.A165CargoTotal=0;this.Z165CargoTotal=0;this.O165CargoTotal=0;this.A166CargoEstado=0;this.Z166CargoEstado=0;this.O166CargoEstado=0;this.ServerEvents=["e110z45_client","e120z45_client"];this.setPrompt("PROMPT_41_91",[38,43]);
this.setPrompt("PROMPT_41_30",[38,53]);this.EnterCtrl=["BTN_ENTER2","BTN_ENTER2_SEPARATOR","BTN_ENTER"];this.VarControlMap.Gx_mode={id:"vMODE",grid:0,type:"char"};this.SetStandaloneVars()}cargo.prototype=new gx.GxObject;gx.setParentObj(new cargo());