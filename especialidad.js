gx.evt.autoSkip=false;function especialidad(){this.ServerClass="Especialidad";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=true;this.SetStandaloneVars=function(){this.AV8ClinicaCodigo=gx.fn.getControlValue("vCLINICACODIGO");this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Clinicacodigo=function(){gx.ajax.validSrvEvt("dyncall","Valid_Clinicacodigo",["gx.O.A41ClinicaCodigo"],[]);return true};this.Valid_Espcodigo=function(){gx.ajax.validSrvEvt("dyncall","Valid_Espcodigo",["gx.O.AV8ClinicaCodigo","gx.O.A41ClinicaCodigo","gx.O.A17EspCodigo","gx.O.A18EspDescripcion"],["A18EspDescripcion","Gx_mode","Z41ClinicaCodigo","Z17EspCodigo","Z18EspDescripcion",["BTN_DELETE2","Enabled"],["BTN_ENTER2","Enabled"]]);
return true};this.e120o31_client=function(){this.executeServerEvent("ENTER",true)};this.e130o31_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[2,5,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,26,27,33,36,38,41,43,46,48,54];this.GXLastCtrlId=54;this.GXValidFnc[2]={fld:"TABLEMAIN",grid:0};this.GXValidFnc[5]={fld:"TABLETOOLBAR",grid:0};this.GXValidFnc[8]={fld:"BTN_FIRST",grid:0};this.GXValidFnc[9]={fld:"BTN_FIRST_SEPARATOR",grid:0};this.GXValidFnc[10]={fld:"BTN_PREVIOUS",grid:0};
this.GXValidFnc[11]={fld:"BTN_PREVIOUS_SEPARATOR",grid:0};this.GXValidFnc[12]={fld:"BTN_NEXT",grid:0};this.GXValidFnc[13]={fld:"BTN_NEXT_SEPARATOR",grid:0};this.GXValidFnc[14]={fld:"BTN_LAST",grid:0};this.GXValidFnc[15]={fld:"BTN_LAST_SEPARATOR",grid:0};this.GXValidFnc[16]={fld:"BTN_SELECT",grid:0};this.GXValidFnc[17]={fld:"BTN_SELECT_SEPARATOR",grid:0};this.GXValidFnc[18]={fld:"BTN_ENTER2",grid:0};this.GXValidFnc[19]={fld:"BTN_ENTER2_SEPARATOR",grid:0};this.GXValidFnc[20]={fld:"BTN_CANCEL2",grid:0};
this.GXValidFnc[21]={fld:"BTN_CANCEL2_SEPARATOR",grid:0};this.GXValidFnc[22]={fld:"BTN_DELETE2",grid:0};this.GXValidFnc[23]={fld:"BTN_DELETE2_SEPARATOR",grid:0};this.GXValidFnc[26]={fld:"GROUPDATA",grid:0};this.GXValidFnc[27]={fld:"TABLE1",grid:0};this.GXValidFnc[33]={fld:"TABLE2",grid:0};this.GXValidFnc[36]={fld:"TEXTBLOCKCLINICACODIGO",format:0,grid:0};this.GXValidFnc[38]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Clinicacodigo,isvalid:null,fld:"CLINICACODIGO",gxz:"Z41ClinicaCodigo",gxold:"O41ClinicaCodigo",gxvar:"A41ClinicaCodigo",ucs:[],op:[],ip:[38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A41ClinicaCodigo=a
},v2z:function(a){gx.O.Z41ClinicaCodigo=a},v2c:function(){gx.fn.setControlValue("CLINICACODIGO",gx.O.A41ClinicaCodigo,0)},c2v:function(){gx.O.A41ClinicaCodigo=this.val()},val:function(){return gx.fn.getControlValue("CLINICACODIGO")},nac:function(){return false}};this.GXValidFnc[41]={fld:"TEXTBLOCKESPCODIGO",format:0,grid:0};this.GXValidFnc[43]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Espcodigo,isvalid:null,fld:"ESPCODIGO",gxz:"Z17EspCodigo",gxold:"O17EspCodigo",gxvar:"A17EspCodigo",ucs:[],op:[48],ip:[48,43,38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A17EspCodigo=a
},v2z:function(a){gx.O.Z17EspCodigo=a},v2c:function(){gx.fn.setControlValue("ESPCODIGO",gx.O.A17EspCodigo,0)},c2v:function(){gx.O.A17EspCodigo=this.val()},val:function(){return gx.fn.getControlValue("ESPCODIGO")},nac:function(){return false}};this.GXValidFnc[46]={fld:"TEXTBLOCKESPDESCRIPCION",format:0,grid:0};this.GXValidFnc[48]={lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"ESPDESCRIPCION",gxz:"Z18EspDescripcion",gxold:"O18EspDescripcion",gxvar:"A18EspDescripcion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A18EspDescripcion=a
},v2z:function(a){gx.O.Z18EspDescripcion=a},v2c:function(){gx.fn.setControlValue("ESPDESCRIPCION",gx.O.A18EspDescripcion,0)},c2v:function(){gx.O.A18EspDescripcion=this.val()},val:function(){return gx.fn.getControlValue("ESPDESCRIPCION")},nac:function(){return false}};this.GXValidFnc[54]={fld:"PROMPT_41",grid:31};this.A41ClinicaCodigo="";this.Z41ClinicaCodigo="";this.O41ClinicaCodigo="";this.A17EspCodigo="";this.Z17EspCodigo="";this.O17EspCodigo="";this.A18EspDescripcion="";this.Z18EspDescripcion="";
this.O18EspDescripcion="";this.AV7Parametros={};this.AV8ClinicaCodigo="";this.ServerEvents=["e120o31_client","e130o31_client"];this.setPrompt("PROMPT_41",[38]);this.EnterCtrl=["BTN_ENTER2","BTN_ENTER2_SEPARATOR","BTN_ENTER"];this.VarControlMap.AV8ClinicaCodigo={id:"vCLINICACODIGO",grid:0,type:"svchar"};this.VarControlMap.Gx_mode={id:"vMODE",grid:0,type:"char"};this.SetStandaloneVars()}especialidad.prototype=new gx.GxObject;gx.setParentObj(new especialidad());