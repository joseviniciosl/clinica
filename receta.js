gx.evt.autoSkip=false;function receta(){this.ServerClass="Receta";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=true;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Clinicacodigo=function(){try{var a=gx.util.balloon.getNew("CLINICACODIGO");this.AnyError=0}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Consultaid=function(){gx.ajax.validSrvEvt("dyncall","Valid_Consultaid",["gx.O.A41ClinicaCodigo","gx.O.A91ConsultaId","gx.O.A19MedicoCodigo"],["A19MedicoCodigo"]);
return true};this.Valid_Recetaid=function(){gx.ajax.validSrvEvt("dyncall","Valid_Recetaid",["gx.O.A41ClinicaCodigo","gx.O.A91ConsultaId","gx.O.A109RecetaId",'gx.date.urlDate(gx.O.A110RecetaFecha,"DMY")',"gx.O.A111RecetaHora","gx.O.A112RecetaObs"],["A110RecetaFecha","A111RecetaHora","A112RecetaObs","A19MedicoCodigo","Gx_mode","Z41ClinicaCodigo","Z91ConsultaId","Z109RecetaId","Z110RecetaFecha","Z111RecetaHora","Z112RecetaObs","Z19MedicoCodigo",["BTN_DELETE2","Enabled"],["BTN_ENTER2","Enabled"]]);return true
};this.Valid_Recetafecha=function(){try{var a=gx.util.balloon.getNew("RECETAFECHA");this.AnyError=0;if(!((new gx.date.gxdate("").compare(this.A110RecetaFecha)==0)||new gx.date.gxdate(this.A110RecetaFecha).compare(gx.date.ymdtod(1753,1,1))>=0)){try{a.setError("Campo Fecha fuera de rango");this.AnyError=1}catch(b){}}}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.e110k27_client=function(){this.executeServerEvent("ENTER",true)};this.e120k27_client=function(){this.executeServerEvent("CANCEL",true)
};this.GXValidFnc=[];this.GXCtrlIds=[2,5,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,26,27,33,36,38,41,43,46,48,51,53,56,58,61,63,66,68,74];this.GXLastCtrlId=74;this.GXValidFnc[2]={fld:"TABLEMAIN",grid:0};this.GXValidFnc[5]={fld:"TABLETOOLBAR",grid:0};this.GXValidFnc[8]={fld:"BTN_FIRST",grid:0};this.GXValidFnc[9]={fld:"BTN_FIRST_SEPARATOR",grid:0};this.GXValidFnc[10]={fld:"BTN_PREVIOUS",grid:0};this.GXValidFnc[11]={fld:"BTN_PREVIOUS_SEPARATOR",grid:0};this.GXValidFnc[12]={fld:"BTN_NEXT",grid:0};
this.GXValidFnc[13]={fld:"BTN_NEXT_SEPARATOR",grid:0};this.GXValidFnc[14]={fld:"BTN_LAST",grid:0};this.GXValidFnc[15]={fld:"BTN_LAST_SEPARATOR",grid:0};this.GXValidFnc[16]={fld:"BTN_SELECT",grid:0};this.GXValidFnc[17]={fld:"BTN_SELECT_SEPARATOR",grid:0};this.GXValidFnc[18]={fld:"BTN_ENTER2",grid:0};this.GXValidFnc[19]={fld:"BTN_ENTER2_SEPARATOR",grid:0};this.GXValidFnc[20]={fld:"BTN_CANCEL2",grid:0};this.GXValidFnc[21]={fld:"BTN_CANCEL2_SEPARATOR",grid:0};this.GXValidFnc[22]={fld:"BTN_DELETE2",grid:0};
this.GXValidFnc[23]={fld:"BTN_DELETE2_SEPARATOR",grid:0};this.GXValidFnc[26]={fld:"GROUPDATA",grid:0};this.GXValidFnc[27]={fld:"TABLE1",grid:0};this.GXValidFnc[33]={fld:"TABLE2",grid:0};this.GXValidFnc[36]={fld:"TEXTBLOCKCLINICACODIGO",format:0,grid:0};this.GXValidFnc[38]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Clinicacodigo,isvalid:null,fld:"CLINICACODIGO",gxz:"Z41ClinicaCodigo",gxold:"O41ClinicaCodigo",gxvar:"A41ClinicaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A41ClinicaCodigo=a
},v2z:function(a){gx.O.Z41ClinicaCodigo=a},v2c:function(){gx.fn.setControlValue("CLINICACODIGO",gx.O.A41ClinicaCodigo,0)},c2v:function(){gx.O.A41ClinicaCodigo=this.val()},val:function(){return gx.fn.getControlValue("CLINICACODIGO")},nac:function(){return false}};this.GXValidFnc[41]={fld:"TEXTBLOCKCONSULTAID",format:0,grid:0};this.GXValidFnc[43]={lvl:0,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Consultaid,isvalid:null,rgrid:[],fld:"CONSULTAID",gxz:"Z91ConsultaId",gxold:"O91ConsultaId",gxvar:"A91ConsultaId",ucs:[],op:[63],ip:[63,43,38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A91ConsultaId=gx.num.intval(a)
},v2z:function(a){gx.O.Z91ConsultaId=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("CONSULTAID",gx.O.A91ConsultaId,0)},c2v:function(){gx.O.A91ConsultaId=this.val()},val:function(){return gx.fn.getIntegerValue("CONSULTAID",",")},nac:function(){return false}};this.GXValidFnc[46]={fld:"TEXTBLOCKRECETAID",format:0,grid:0};this.GXValidFnc[48]={lvl:0,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Recetaid,isvalid:null,rgrid:[],fld:"RECETAID",gxz:"Z109RecetaId",gxold:"O109RecetaId",gxvar:"A109RecetaId",ucs:[],op:[68,58,53],ip:[68,58,53,48,43,38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A109RecetaId=gx.num.intval(a)
},v2z:function(a){gx.O.Z109RecetaId=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("RECETAID",gx.O.A109RecetaId,0)},c2v:function(){gx.O.A109RecetaId=this.val()},val:function(){return gx.fn.getIntegerValue("RECETAID",",")},nac:function(){return false}};this.GXValidFnc[51]={fld:"TEXTBLOCKRECETAFECHA",format:0,grid:0};this.GXValidFnc[53]={lvl:0,type:"date",len:8,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Recetafecha,isvalid:null,fld:"RECETAFECHA",gxz:"Z110RecetaFecha",gxold:"O110RecetaFecha",gxvar:"A110RecetaFecha",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/99",dec:0},ucs:[],op:[53],ip:[53],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A110RecetaFecha=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.Z110RecetaFecha=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setControlValue("RECETAFECHA",gx.O.A110RecetaFecha,0)},c2v:function(){gx.O.A110RecetaFecha=this.val()},val:function(){return gx.fn.getControlValue("RECETAFECHA")},nac:function(){return false}};this.GXValidFnc[56]={fld:"TEXTBLOCKRECETAHORA",format:0,grid:0};this.GXValidFnc[58]={lvl:0,type:"char",len:8,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"RECETAHORA",gxz:"Z111RecetaHora",gxold:"O111RecetaHora",gxvar:"A111RecetaHora",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A111RecetaHora=a
},v2z:function(a){gx.O.Z111RecetaHora=a},v2c:function(){gx.fn.setControlValue("RECETAHORA",gx.O.A111RecetaHora,0)},c2v:function(){gx.O.A111RecetaHora=this.val()},val:function(){return gx.fn.getControlValue("RECETAHORA")},nac:function(){return false}};this.GXValidFnc[61]={fld:"TEXTBLOCKMEDICOCODIGO",format:0,grid:0};this.GXValidFnc[63]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"MEDICOCODIGO",gxz:"Z19MedicoCodigo",gxold:"O19MedicoCodigo",gxvar:"A19MedicoCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A19MedicoCodigo=a
},v2z:function(a){gx.O.Z19MedicoCodigo=a},v2c:function(){gx.fn.setControlValue("MEDICOCODIGO",gx.O.A19MedicoCodigo,0)},c2v:function(){gx.O.A19MedicoCodigo=this.val()},val:function(){return gx.fn.getControlValue("MEDICOCODIGO")},nac:function(){return false}};this.GXValidFnc[66]={fld:"TEXTBLOCKRECETAOBS",format:0,grid:0};this.GXValidFnc[68]={lvl:0,type:"svchar",len:600,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"RECETAOBS",gxz:"Z112RecetaObs",gxold:"O112RecetaObs",gxvar:"A112RecetaObs",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A112RecetaObs=a
},v2z:function(a){gx.O.Z112RecetaObs=a},v2c:function(){gx.fn.setControlValue("RECETAOBS",gx.O.A112RecetaObs,0)},c2v:function(){gx.O.A112RecetaObs=this.val()},val:function(){return gx.fn.getControlValue("RECETAOBS")},nac:function(){return false}};this.GXValidFnc[74]={fld:"PROMPT_41_91",grid:27};this.A41ClinicaCodigo="";this.Z41ClinicaCodigo="";this.O41ClinicaCodigo="";this.A91ConsultaId=0;this.Z91ConsultaId=0;this.O91ConsultaId=0;this.A109RecetaId=0;this.Z109RecetaId=0;this.O109RecetaId=0;this.A110RecetaFecha=gx.date.nullDate();
this.Z110RecetaFecha=gx.date.nullDate();this.O110RecetaFecha=gx.date.nullDate();this.A111RecetaHora="";this.Z111RecetaHora="";this.O111RecetaHora="";this.A19MedicoCodigo="";this.Z19MedicoCodigo="";this.O19MedicoCodigo="";this.A112RecetaObs="";this.Z112RecetaObs="";this.O112RecetaObs="";this.ServerEvents=["e110k27_client","e120k27_client"];this.setPrompt("PROMPT_41_91",[38,43]);this.EnterCtrl=["BTN_ENTER2","BTN_ENTER2_SEPARATOR","BTN_ENTER"];this.VarControlMap.Gx_mode={id:"vMODE",grid:0,type:"char"};
this.SetStandaloneVars()}receta.prototype=new gx.GxObject;gx.setParentObj(new receta());