gx.evt.autoSkip=false;function unidadmedida(){this.ServerClass="UnidadMedida";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=true;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Clinicacodigo=function(){gx.ajax.validSrvEvt("dyncall","Valid_Clinicacodigo",["gx.O.A41ClinicaCodigo"],[]);return true};this.Valid_Unidadmedidacodigo=function(){gx.ajax.validSrvEvt("dyncall","Valid_Unidadmedidacodigo",["gx.O.A41ClinicaCodigo","gx.O.A380UnidadMedidaCodigo","gx.O.A381UnidadMedidaDescripcion"],["A381UnidadMedidaDescripcion","Gx_mode","Z41ClinicaCodigo","Z380UnidadMedidaCodigo","Z381UnidadMedidaDescripcion",["BTN_DELETE2","Enabled"],["BTN_ENTER2","Enabled"]]);
return true};this.e111p78_client=function(){this.executeServerEvent("ENTER",true)};this.e121p78_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[2,5,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,26,27,33,36,38,41,43,46,48,54];this.GXLastCtrlId=54;this.GXValidFnc[2]={fld:"TABLEMAIN",grid:0};this.GXValidFnc[5]={fld:"TABLETOOLBAR",grid:0};this.GXValidFnc[8]={fld:"BTN_FIRST",grid:0};this.GXValidFnc[9]={fld:"BTN_FIRST_SEPARATOR",grid:0};this.GXValidFnc[10]={fld:"BTN_PREVIOUS",grid:0};
this.GXValidFnc[11]={fld:"BTN_PREVIOUS_SEPARATOR",grid:0};this.GXValidFnc[12]={fld:"BTN_NEXT",grid:0};this.GXValidFnc[13]={fld:"BTN_NEXT_SEPARATOR",grid:0};this.GXValidFnc[14]={fld:"BTN_LAST",grid:0};this.GXValidFnc[15]={fld:"BTN_LAST_SEPARATOR",grid:0};this.GXValidFnc[16]={fld:"BTN_SELECT",grid:0};this.GXValidFnc[17]={fld:"BTN_SELECT_SEPARATOR",grid:0};this.GXValidFnc[18]={fld:"BTN_ENTER2",grid:0};this.GXValidFnc[19]={fld:"BTN_ENTER2_SEPARATOR",grid:0};this.GXValidFnc[20]={fld:"BTN_CANCEL2",grid:0};
this.GXValidFnc[21]={fld:"BTN_CANCEL2_SEPARATOR",grid:0};this.GXValidFnc[22]={fld:"BTN_DELETE2",grid:0};this.GXValidFnc[23]={fld:"BTN_DELETE2_SEPARATOR",grid:0};this.GXValidFnc[26]={fld:"GROUPDATA",grid:0};this.GXValidFnc[27]={fld:"TABLE1",grid:0};this.GXValidFnc[33]={fld:"TABLE2",grid:0};this.GXValidFnc[36]={fld:"TEXTBLOCKCLINICACODIGO",format:0,grid:0};this.GXValidFnc[38]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Clinicacodigo,isvalid:null,fld:"CLINICACODIGO",gxz:"Z41ClinicaCodigo",gxold:"O41ClinicaCodigo",gxvar:"A41ClinicaCodigo",ucs:[],op:[],ip:[38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A41ClinicaCodigo=a
},v2z:function(a){gx.O.Z41ClinicaCodigo=a},v2c:function(){gx.fn.setControlValue("CLINICACODIGO",gx.O.A41ClinicaCodigo,0)},c2v:function(){gx.O.A41ClinicaCodigo=this.val()},val:function(){return gx.fn.getControlValue("CLINICACODIGO")},nac:function(){return false}};this.GXValidFnc[41]={fld:"TEXTBLOCKUNIDADMEDIDACODIGO",format:0,grid:0};this.GXValidFnc[43]={lvl:0,type:"svchar",len:15,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Unidadmedidacodigo,isvalid:null,fld:"UNIDADMEDIDACODIGO",gxz:"Z380UnidadMedidaCodigo",gxold:"O380UnidadMedidaCodigo",gxvar:"A380UnidadMedidaCodigo",ucs:[],op:[48],ip:[48,43,38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A380UnidadMedidaCodigo=a
},v2z:function(a){gx.O.Z380UnidadMedidaCodigo=a},v2c:function(){gx.fn.setControlValue("UNIDADMEDIDACODIGO",gx.O.A380UnidadMedidaCodigo,0)},c2v:function(){gx.O.A380UnidadMedidaCodigo=this.val()},val:function(){return gx.fn.getControlValue("UNIDADMEDIDACODIGO")},nac:function(){return false}};this.GXValidFnc[46]={fld:"TEXTBLOCKUNIDADMEDIDADESCRIPCION",format:0,grid:0};this.GXValidFnc[48]={lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"UNIDADMEDIDADESCRIPCION",gxz:"Z381UnidadMedidaDescripcion",gxold:"O381UnidadMedidaDescripcion",gxvar:"A381UnidadMedidaDescripcion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A381UnidadMedidaDescripcion=a
},v2z:function(a){gx.O.Z381UnidadMedidaDescripcion=a},v2c:function(){gx.fn.setControlValue("UNIDADMEDIDADESCRIPCION",gx.O.A381UnidadMedidaDescripcion,0)},c2v:function(){gx.O.A381UnidadMedidaDescripcion=this.val()},val:function(){return gx.fn.getControlValue("UNIDADMEDIDADESCRIPCION")},nac:function(){return false}};this.GXValidFnc[54]={fld:"PROMPT_41",grid:78};this.A41ClinicaCodigo="";this.Z41ClinicaCodigo="";this.O41ClinicaCodigo="";this.A380UnidadMedidaCodigo="";this.Z380UnidadMedidaCodigo="";this.O380UnidadMedidaCodigo="";
this.A381UnidadMedidaDescripcion="";this.Z381UnidadMedidaDescripcion="";this.O381UnidadMedidaDescripcion="";this.ServerEvents=["e111p78_client","e121p78_client"];this.setPrompt("PROMPT_41",[38]);this.EnterCtrl=["BTN_ENTER2","BTN_ENTER2_SEPARATOR","BTN_ENTER"];this.VarControlMap.Gx_mode={id:"vMODE",grid:0,type:"char"};this.SetStandaloneVars()}unidadmedida.prototype=new gx.GxObject;gx.setParentObj(new unidadmedida());