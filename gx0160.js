gx.evt.autoSkip=false;function gx0160(){this.ServerClass="Gx0160";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=true;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV10pClinicaCodigo=gx.fn.getControlValue("vPCLINICACODIGO");this.AV11pTipoOrdCodigo=gx.fn.getControlValue("vPTIPOORDCODIGO")};this.e131d2_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e141d1_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];
this.GXCtrlIds=[2,8,9,12,14,17,19,22,24,27,29,32,33,37,38,39,40,43];this.GXLastCtrlId=43;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",36,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0160",[],false,1,false,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");this.Grid1Container.addBitmap("&Linkselection","vLINKSELECTION",37,0,"px",17,"px",null,"","");this.Grid1Container.addSingleLineEdit(41,38,"CLINICACODIGO","Código","","ClinicaCodigo","svchar",0,"px",10,10,"left",null,[],41,"ClinicaCodigo",true,0,false,false);
this.Grid1Container.addSingleLineEdit(150,39,"TIPOORDCODIGO","Orden","","TipoOrdCodigo","svchar",0,"px",10,10,"left",null,[],150,"TipoOrdCodigo",true,0,false,false);this.Grid1Container.addSingleLineEdit(151,40,"TIPOORDDESCRIPCION","Descripción","Seleccionar","TipoOrdDescripcion","svchar",0,"px",100,100,"left",null,[],151,"TipoOrdDescripcion",true,0,false,false);this.setGrid(this.Grid1Container);this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[8]={fld:"GROUP1",grid:0};this.GXValidFnc[9]={fld:"TABLE2",grid:0};
this.GXValidFnc[12]={fld:"TEXTBLOCKCLINICACODIGO",format:0,grid:0};this.GXValidFnc[14]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCCLINICACODIGO",gxz:"ZV6cClinicaCodigo",gxold:"OV6cClinicaCodigo",gxvar:"AV6cClinicaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV6cClinicaCodigo=a},v2z:function(a){gx.O.ZV6cClinicaCodigo=a},v2c:function(){gx.fn.setControlValue("vCCLINICACODIGO",gx.O.AV6cClinicaCodigo,0)},c2v:function(){gx.O.AV6cClinicaCodigo=this.val()
},val:function(){return gx.fn.getControlValue("vCCLINICACODIGO")},nac:function(){return false}};this.GXValidFnc[17]={fld:"TEXTBLOCKTIPOORDCODIGO",format:0,grid:0};this.GXValidFnc[19]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCTIPOORDCODIGO",gxz:"ZV7cTipoOrdCodigo",gxold:"OV7cTipoOrdCodigo",gxvar:"AV7cTipoOrdCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7cTipoOrdCodigo=a},v2z:function(a){gx.O.ZV7cTipoOrdCodigo=a},v2c:function(){gx.fn.setControlValue("vCTIPOORDCODIGO",gx.O.AV7cTipoOrdCodigo,0)
},c2v:function(){gx.O.AV7cTipoOrdCodigo=this.val()},val:function(){return gx.fn.getControlValue("vCTIPOORDCODIGO")},nac:function(){return false}};this.GXValidFnc[22]={fld:"TEXTBLOCKTIPOORDDESCRIPCION",format:0,grid:0};this.GXValidFnc[24]={lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCTIPOORDDESCRIPCION",gxz:"ZV8cTipoOrdDescripcion",gxold:"OV8cTipoOrdDescripcion",gxvar:"AV8cTipoOrdDescripcion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV8cTipoOrdDescripcion=a
},v2z:function(a){gx.O.ZV8cTipoOrdDescripcion=a},v2c:function(){gx.fn.setControlValue("vCTIPOORDDESCRIPCION",gx.O.AV8cTipoOrdDescripcion,0)},c2v:function(){gx.O.AV8cTipoOrdDescripcion=this.val()},val:function(){return gx.fn.getControlValue("vCTIPOORDDESCRIPCION")},nac:function(){return false}};this.GXValidFnc[27]={fld:"TEXTBLOCKTIPOORDESTADO",format:0,grid:0};this.GXValidFnc[29]={lvl:0,type:"int",len:1,dec:0,sign:false,pic:"9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCTIPOORDESTADO",gxz:"ZV9cTipoOrdEstado",gxold:"OV9cTipoOrdEstado",gxvar:"AV9cTipoOrdEstado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.AV9cTipoOrdEstado=gx.num.intval(a)
},v2z:function(a){gx.O.ZV9cTipoOrdEstado=gx.num.intval(a)},v2c:function(){gx.fn.setComboBoxValue("vCTIPOORDESTADO",gx.O.AV9cTipoOrdEstado)},c2v:function(){gx.O.AV9cTipoOrdEstado=this.val()},val:function(){return gx.fn.getIntegerValue("vCTIPOORDESTADO",",")},nac:function(){return false}};this.GXValidFnc[32]={fld:"GROUP2",grid:0};this.GXValidFnc[33]={fld:"TABLE3",grid:0};this.GXValidFnc[37]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV5LinkSelection=a
},v2z:function(a){gx.O.ZV5LinkSelection=a},v2c:function(){},c2v:function(){gx.O.AV5LinkSelection=this.val()},val:function(){return gx.fn.getGridControlValue("vLINKSELECTION",gx.fn.currentGridRowImpl(36))},nac:function(){return false}};this.GXValidFnc[38]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CLINICACODIGO",gxz:"Z41ClinicaCodigo",gxold:"O41ClinicaCodigo",gxvar:"A41ClinicaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A41ClinicaCodigo=a
},v2z:function(a){gx.O.Z41ClinicaCodigo=a},v2c:function(){gx.fn.setGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(36),gx.O.A41ClinicaCodigo,0)},c2v:function(){gx.O.A41ClinicaCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(36))},nac:function(){return false}};this.GXValidFnc[39]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"TIPOORDCODIGO",gxz:"Z150TipoOrdCodigo",gxold:"O150TipoOrdCodigo",gxvar:"A150TipoOrdCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A150TipoOrdCodigo=a
},v2z:function(a){gx.O.Z150TipoOrdCodigo=a},v2c:function(){gx.fn.setGridControlValue("TIPOORDCODIGO",gx.fn.currentGridRowImpl(36),gx.O.A150TipoOrdCodigo,0)},c2v:function(){gx.O.A150TipoOrdCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("TIPOORDCODIGO",gx.fn.currentGridRowImpl(36))},nac:function(){return false}};this.GXValidFnc[40]={lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"TIPOORDDESCRIPCION",gxz:"Z151TipoOrdDescripcion",gxold:"O151TipoOrdDescripcion",gxvar:"A151TipoOrdDescripcion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A151TipoOrdDescripcion=a
},v2z:function(a){gx.O.Z151TipoOrdDescripcion=a},v2c:function(){gx.fn.setGridControlValue("TIPOORDDESCRIPCION",gx.fn.currentGridRowImpl(36),gx.O.A151TipoOrdDescripcion,0)},c2v:function(){gx.O.A151TipoOrdDescripcion=this.val()},val:function(){return gx.fn.getGridControlValue("TIPOORDDESCRIPCION",gx.fn.currentGridRowImpl(36))},nac:function(){return false}};this.GXValidFnc[43]={fld:"TABLE4",grid:0};this.AV6cClinicaCodigo="";this.ZV6cClinicaCodigo="";this.OV6cClinicaCodigo="";this.AV7cTipoOrdCodigo="";
this.ZV7cTipoOrdCodigo="";this.OV7cTipoOrdCodigo="";this.AV8cTipoOrdDescripcion="";this.ZV8cTipoOrdDescripcion="";this.OV8cTipoOrdDescripcion="";this.AV9cTipoOrdEstado=0;this.ZV9cTipoOrdEstado=0;this.OV9cTipoOrdEstado=0;this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z41ClinicaCodigo="";this.O41ClinicaCodigo="";this.Z150TipoOrdCodigo="";this.O150TipoOrdCodigo="";this.Z151TipoOrdDescripcion="";this.O151TipoOrdDescripcion="";this.AV10pClinicaCodigo="";this.AV11pTipoOrdCodigo="";this.A152TipoOrdEstado=0;
this.AV5LinkSelection="";this.A41ClinicaCodigo="";this.A150TipoOrdCodigo="";this.A151TipoOrdDescripcion="";this.ServerEvents=["e131d2_client","e141d1_client"];this.VarControlMap.AV10pClinicaCodigo={id:"vPCLINICACODIGO",grid:0,type:"svchar"};this.VarControlMap.AV11pTipoOrdCodigo={id:"vPTIPOORDCODIGO",grid:0,type:"svchar"};this.Grid1Container.addRefreshingVar(this.GXValidFnc[14]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[19]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[24]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[29]);
this.SetStandaloneVars()}gx0160.prototype=new gx.GxObject;gx.setParentObj(new gx0160());