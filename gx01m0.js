gx.evt.autoSkip=false;function gx01m0(){this.ServerClass="Gx01M0";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=true;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV11pClinicaCodigo=gx.fn.getControlValue("vPCLINICACODIGO");this.AV12pCalendarioCodigo=gx.fn.getControlValue("vPCALENDARIOCODIGO")};this.e13282_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e14281_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];
this.GXCtrlIds=[2,8,9,12,14,17,19,22,24,27,29,32,34,37,38,42,43,44,45,46,47,50];this.GXLastCtrlId=50;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",41,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx01m0",[],false,1,false,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");this.Grid1Container.addBitmap("&Linkselection","vLINKSELECTION",42,0,"px",17,"px",null,"","");this.Grid1Container.addSingleLineEdit(41,43,"CLINICACODIGO","Código","","ClinicaCodigo","svchar",0,"px",10,10,"left",null,[],41,"ClinicaCodigo",true,0,false,false);
this.Grid1Container.addSingleLineEdit(233,44,"CALENDARIOCODIGO","Id","","CalendarioCodigo","svchar",0,"px",10,10,"left",null,[],233,"CalendarioCodigo",true,0,false,false);this.Grid1Container.addSingleLineEdit(67,45,"PACIENTEID","Paciente","","PacienteId","int",0,"px",9,9,"right",null,[],67,"PacienteId",true,0,false,false);this.Grid1Container.addSingleLineEdit(235,46,"CALENDARIOINICIO","Inicia","","CalendarioInicio","dtime",0,"px",14,8,"right",null,[],235,"CalendarioInicio",true,5,false,false);this.Grid1Container.addSingleLineEdit(236,47,"CALENDARIOFINAL","Final","","CalendarioFinal","dtime",0,"px",14,8,"right",null,[],236,"CalendarioFinal",true,5,false,false);
this.setGrid(this.Grid1Container);this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[8]={fld:"GROUP1",grid:0};this.GXValidFnc[9]={fld:"TABLE2",grid:0};this.GXValidFnc[12]={fld:"TEXTBLOCKCLINICACODIGO",format:0,grid:0};this.GXValidFnc[14]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCCLINICACODIGO",gxz:"ZV6cClinicaCodigo",gxold:"OV6cClinicaCodigo",gxvar:"AV6cClinicaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV6cClinicaCodigo=a
},v2z:function(a){gx.O.ZV6cClinicaCodigo=a},v2c:function(){gx.fn.setControlValue("vCCLINICACODIGO",gx.O.AV6cClinicaCodigo,0)},c2v:function(){gx.O.AV6cClinicaCodigo=this.val()},val:function(){return gx.fn.getControlValue("vCCLINICACODIGO")},nac:function(){return false}};this.GXValidFnc[17]={fld:"TEXTBLOCKCALENDARIOCODIGO",format:0,grid:0};this.GXValidFnc[19]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCCALENDARIOCODIGO",gxz:"ZV7cCalendarioCodigo",gxold:"OV7cCalendarioCodigo",gxvar:"AV7cCalendarioCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7cCalendarioCodigo=a
},v2z:function(a){gx.O.ZV7cCalendarioCodigo=a},v2c:function(){gx.fn.setControlValue("vCCALENDARIOCODIGO",gx.O.AV7cCalendarioCodigo,0)},c2v:function(){gx.O.AV7cCalendarioCodigo=this.val()},val:function(){return gx.fn.getControlValue("vCCALENDARIOCODIGO")},nac:function(){return false}};this.GXValidFnc[22]={fld:"TEXTBLOCKPACIENTEID",format:0,grid:0};this.GXValidFnc[24]={lvl:0,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCPACIENTEID",gxz:"ZV8cPacienteId",gxold:"OV8cPacienteId",gxvar:"AV8cPacienteId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV8cPacienteId=gx.num.intval(a)
},v2z:function(a){gx.O.ZV8cPacienteId=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCPACIENTEID",gx.O.AV8cPacienteId,0)},c2v:function(){gx.O.AV8cPacienteId=this.val()},val:function(){return gx.fn.getIntegerValue("vCPACIENTEID",",")},nac:function(){return false}};this.GXValidFnc[27]={fld:"TEXTBLOCKCALENDARIOINICIO",format:0,grid:0};this.GXValidFnc[29]={lvl:0,type:"dtime",len:8,dec:5,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCCALENDARIOINICIO",gxz:"ZV9cCalendarioInicio",gxold:"OV9cCalendarioInicio",gxvar:"AV9cCalendarioInicio",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV9cCalendarioInicio=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.ZV9cCalendarioInicio=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setControlValue("vCCALENDARIOINICIO",gx.O.AV9cCalendarioInicio,0)},c2v:function(){gx.O.AV9cCalendarioInicio=this.val()},val:function(){return gx.fn.getControlValue("vCCALENDARIOINICIO")},nac:function(){return false}};this.GXValidFnc[32]={fld:"TEXTBLOCKCALENDARIOFINAL",format:0,grid:0};this.GXValidFnc[34]={lvl:0,type:"dtime",len:8,dec:5,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCCALENDARIOFINAL",gxz:"ZV10cCalendarioFinal",gxold:"OV10cCalendarioFinal",gxvar:"AV10cCalendarioFinal",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV10cCalendarioFinal=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.ZV10cCalendarioFinal=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setControlValue("vCCALENDARIOFINAL",gx.O.AV10cCalendarioFinal,0)},c2v:function(){gx.O.AV10cCalendarioFinal=this.val()},val:function(){return gx.fn.getControlValue("vCCALENDARIOFINAL")},nac:function(){return false}};this.GXValidFnc[37]={fld:"GROUP2",grid:0};this.GXValidFnc[38]={fld:"TABLE3",grid:0};this.GXValidFnc[42]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:41,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV5LinkSelection=a
},v2z:function(a){gx.O.ZV5LinkSelection=a},v2c:function(){},c2v:function(){gx.O.AV5LinkSelection=this.val()},val:function(){return gx.fn.getGridControlValue("vLINKSELECTION",gx.fn.currentGridRowImpl(41))},nac:function(){return false}};this.GXValidFnc[43]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:41,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CLINICACODIGO",gxz:"Z41ClinicaCodigo",gxold:"O41ClinicaCodigo",gxvar:"A41ClinicaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A41ClinicaCodigo=a
},v2z:function(a){gx.O.Z41ClinicaCodigo=a},v2c:function(){gx.fn.setGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(41),gx.O.A41ClinicaCodigo,0)},c2v:function(){gx.O.A41ClinicaCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(41))},nac:function(){return false}};this.GXValidFnc[44]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:41,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CALENDARIOCODIGO",gxz:"Z233CalendarioCodigo",gxold:"O233CalendarioCodigo",gxvar:"A233CalendarioCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A233CalendarioCodigo=a
},v2z:function(a){gx.O.Z233CalendarioCodigo=a},v2c:function(){gx.fn.setGridControlValue("CALENDARIOCODIGO",gx.fn.currentGridRowImpl(41),gx.O.A233CalendarioCodigo,0)},c2v:function(){gx.O.A233CalendarioCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("CALENDARIOCODIGO",gx.fn.currentGridRowImpl(41))},nac:function(){return false}};this.GXValidFnc[45]={lvl:2,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:1,grid:41,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PACIENTEID",gxz:"Z67PacienteId",gxold:"O67PacienteId",gxvar:"A67PacienteId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A67PacienteId=gx.num.intval(a)
},v2z:function(a){gx.O.Z67PacienteId=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("PACIENTEID",gx.fn.currentGridRowImpl(41),gx.O.A67PacienteId,0)},c2v:function(){gx.O.A67PacienteId=this.val()},val:function(){return gx.fn.getGridIntegerValue("PACIENTEID",gx.fn.currentGridRowImpl(41),",")},nac:function(){return false}};this.GXValidFnc[46]={lvl:2,type:"dtime",len:8,dec:5,sign:false,ro:1,grid:41,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CALENDARIOINICIO",gxz:"Z235CalendarioInicio",gxold:"O235CalendarioInicio",gxvar:"A235CalendarioInicio",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A235CalendarioInicio=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.Z235CalendarioInicio=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setGridControlValue("CALENDARIOINICIO",gx.fn.currentGridRowImpl(41),gx.O.A235CalendarioInicio,0)},c2v:function(){gx.O.A235CalendarioInicio=this.val()},val:function(){return gx.fn.getGridControlValue("CALENDARIOINICIO",gx.fn.currentGridRowImpl(41))},nac:function(){return false}};this.GXValidFnc[47]={lvl:2,type:"dtime",len:8,dec:5,sign:false,ro:1,grid:41,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CALENDARIOFINAL",gxz:"Z236CalendarioFinal",gxold:"O236CalendarioFinal",gxvar:"A236CalendarioFinal",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/99 99:99",dec:5},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A236CalendarioFinal=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.Z236CalendarioFinal=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setGridControlValue("CALENDARIOFINAL",gx.fn.currentGridRowImpl(41),gx.O.A236CalendarioFinal,0)},c2v:function(){gx.O.A236CalendarioFinal=this.val()},val:function(){return gx.fn.getGridControlValue("CALENDARIOFINAL",gx.fn.currentGridRowImpl(41))},nac:function(){return false}};this.GXValidFnc[50]={fld:"TABLE4",grid:0};this.AV6cClinicaCodigo="";this.ZV6cClinicaCodigo="";this.OV6cClinicaCodigo="";this.AV7cCalendarioCodigo="";
this.ZV7cCalendarioCodigo="";this.OV7cCalendarioCodigo="";this.AV8cPacienteId=0;this.ZV8cPacienteId=0;this.OV8cPacienteId=0;this.AV9cCalendarioInicio=gx.date.nullDate();this.ZV9cCalendarioInicio=gx.date.nullDate();this.OV9cCalendarioInicio=gx.date.nullDate();this.AV10cCalendarioFinal=gx.date.nullDate();this.ZV10cCalendarioFinal=gx.date.nullDate();this.OV10cCalendarioFinal=gx.date.nullDate();this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z41ClinicaCodigo="";this.O41ClinicaCodigo="";this.Z233CalendarioCodigo="";
this.O233CalendarioCodigo="";this.Z67PacienteId=0;this.O67PacienteId=0;this.Z235CalendarioInicio=gx.date.nullDate();this.O235CalendarioInicio=gx.date.nullDate();this.Z236CalendarioFinal=gx.date.nullDate();this.O236CalendarioFinal=gx.date.nullDate();this.AV11pClinicaCodigo="";this.AV12pCalendarioCodigo="";this.AV5LinkSelection="";this.A41ClinicaCodigo="";this.A233CalendarioCodigo="";this.A67PacienteId=0;this.A235CalendarioInicio=gx.date.nullDate();this.A236CalendarioFinal=gx.date.nullDate();this.ServerEvents=["e13282_client","e14281_client"];
this.VarControlMap.AV11pClinicaCodigo={id:"vPCLINICACODIGO",grid:0,type:"svchar"};this.VarControlMap.AV12pCalendarioCodigo={id:"vPCALENDARIOCODIGO",grid:0,type:"svchar"};this.Grid1Container.addRefreshingVar(this.GXValidFnc[14]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[19]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[24]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[29]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[34]);this.SetStandaloneVars()}gx01m0.prototype=new gx.GxObject;
gx.setParentObj(new gx01m0());