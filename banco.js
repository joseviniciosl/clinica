gx.evt.autoSkip=false;function banco(){this.ServerClass="Banco";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=true;this.SetStandaloneVars=function(){this.AV8ClinicaCodigo=gx.fn.getControlValue("vCLINICACODIGO");this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Clinicacodigo=function(){gx.ajax.validSrvEvt("dyncall","Valid_Clinicacodigo",["gx.O.A41ClinicaCodigo"],[]);return true};this.Valid_Bancocodigo=function(){gx.ajax.validSrvEvt("dyncall","Valid_Bancocodigo",["gx.O.AV8ClinicaCodigo","gx.O.A41ClinicaCodigo","gx.O.A126BancoCodigo","gx.O.A127BancoDescripcion"],["A127BancoDescripcion","Gx_mode","Z41ClinicaCodigo","Z126BancoCodigo","Z127BancoDescripcion",["BTN_DELETE2","Enabled"],["BTN_ENTER2","Enabled"]]);
return true};this.e120q34_client=function(){this.executeServerEvent("ENTER",true)};this.e130q34_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[2,5,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,26,27,33,36,38,41,43,46,48,54];this.GXLastCtrlId=54;this.GXValidFnc[2]={fld:"TABLEMAIN",grid:0};this.GXValidFnc[5]={fld:"TABLETOOLBAR",grid:0};this.GXValidFnc[8]={fld:"BTN_FIRST",grid:0};this.GXValidFnc[9]={fld:"BTN_FIRST_SEPARATOR",grid:0};this.GXValidFnc[10]={fld:"BTN_PREVIOUS",grid:0};
this.GXValidFnc[11]={fld:"BTN_PREVIOUS_SEPARATOR",grid:0};this.GXValidFnc[12]={fld:"BTN_NEXT",grid:0};this.GXValidFnc[13]={fld:"BTN_NEXT_SEPARATOR",grid:0};this.GXValidFnc[14]={fld:"BTN_LAST",grid:0};this.GXValidFnc[15]={fld:"BTN_LAST_SEPARATOR",grid:0};this.GXValidFnc[16]={fld:"BTN_SELECT",grid:0};this.GXValidFnc[17]={fld:"BTN_SELECT_SEPARATOR",grid:0};this.GXValidFnc[18]={fld:"BTN_ENTER2",grid:0};this.GXValidFnc[19]={fld:"BTN_ENTER2_SEPARATOR",grid:0};this.GXValidFnc[20]={fld:"BTN_CANCEL2",grid:0};
this.GXValidFnc[21]={fld:"BTN_CANCEL2_SEPARATOR",grid:0};this.GXValidFnc[22]={fld:"BTN_DELETE2",grid:0};this.GXValidFnc[23]={fld:"BTN_DELETE2_SEPARATOR",grid:0};this.GXValidFnc[26]={fld:"GROUPDATA",grid:0};this.GXValidFnc[27]={fld:"TABLE1",grid:0};this.GXValidFnc[33]={fld:"TABLE2",grid:0};this.GXValidFnc[36]={fld:"TEXTBLOCKCLINICACODIGO",format:0,grid:0};this.GXValidFnc[38]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Clinicacodigo,isvalid:null,fld:"CLINICACODIGO",gxz:"Z41ClinicaCodigo",gxold:"O41ClinicaCodigo",gxvar:"A41ClinicaCodigo",ucs:[],op:[],ip:[38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A41ClinicaCodigo=a
},v2z:function(a){gx.O.Z41ClinicaCodigo=a},v2c:function(){gx.fn.setControlValue("CLINICACODIGO",gx.O.A41ClinicaCodigo,0)},c2v:function(){gx.O.A41ClinicaCodigo=this.val()},val:function(){return gx.fn.getControlValue("CLINICACODIGO")},nac:function(){return false}};this.GXValidFnc[41]={fld:"TEXTBLOCKBANCOCODIGO",format:0,grid:0};this.GXValidFnc[43]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Bancocodigo,isvalid:null,fld:"BANCOCODIGO",gxz:"Z126BancoCodigo",gxold:"O126BancoCodigo",gxvar:"A126BancoCodigo",ucs:[],op:[48],ip:[48,43,38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A126BancoCodigo=a
},v2z:function(a){gx.O.Z126BancoCodigo=a},v2c:function(){gx.fn.setControlValue("BANCOCODIGO",gx.O.A126BancoCodigo,0)},c2v:function(){gx.O.A126BancoCodigo=this.val()},val:function(){return gx.fn.getControlValue("BANCOCODIGO")},nac:function(){return false}};this.GXValidFnc[46]={fld:"TEXTBLOCKBANCODESCRIPCION",format:0,grid:0};this.GXValidFnc[48]={lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"BANCODESCRIPCION",gxz:"Z127BancoDescripcion",gxold:"O127BancoDescripcion",gxvar:"A127BancoDescripcion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A127BancoDescripcion=a
},v2z:function(a){gx.O.Z127BancoDescripcion=a},v2c:function(){gx.fn.setControlValue("BANCODESCRIPCION",gx.O.A127BancoDescripcion,0)},c2v:function(){gx.O.A127BancoDescripcion=this.val()},val:function(){return gx.fn.getControlValue("BANCODESCRIPCION")},nac:function(){return false}};this.GXValidFnc[54]={fld:"PROMPT_41",grid:34};this.A41ClinicaCodigo="";this.Z41ClinicaCodigo="";this.O41ClinicaCodigo="";this.A126BancoCodigo="";this.Z126BancoCodigo="";this.O126BancoCodigo="";this.A127BancoDescripcion="";
this.Z127BancoDescripcion="";this.O127BancoDescripcion="";this.AV7Parametros={};this.AV8ClinicaCodigo="";this.ServerEvents=["e120q34_client","e130q34_client"];this.setPrompt("PROMPT_41",[38]);this.EnterCtrl=["BTN_ENTER2","BTN_ENTER2_SEPARATOR","BTN_ENTER"];this.VarControlMap.AV8ClinicaCodigo={id:"vCLINICACODIGO",grid:0,type:"svchar"};this.VarControlMap.Gx_mode={id:"vMODE",grid:0,type:"char"};this.SetStandaloneVars()}banco.prototype=new gx.GxObject;gx.setParentObj(new banco());