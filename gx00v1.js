gx.evt.autoSkip=false;function gx00v1(){this.ServerClass="Gx00V1";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=true;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV8pClinicaCodigo=gx.fn.getControlValue("vPCLINICACODIGO");this.AV9pEspCodigo=gx.fn.getControlValue("vPESPCODIGO")};this.e13112_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e14111_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[2,8,9,12,14,17,19,22,23,27,28,29,30,33];
this.GXLastCtrlId=33;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",26,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00v1",[],false,1,false,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");this.Grid1Container.addBitmap("&Linkselection","vLINKSELECTION",27,0,"px",17,"px",null,"","");this.Grid1Container.addSingleLineEdit(17,28,"ESPCODIGO","Especialidad","","EspCodigo","svchar",0,"px",10,10,"left",null,[],17,"EspCodigo",true,0,false,false);
this.Grid1Container.addSingleLineEdit(18,29,"ESPDESCRIPCION","Descripción","Seleccionar","EspDescripcion","svchar",0,"px",100,100,"left",null,[],18,"EspDescripcion",true,0,false,false);this.Grid1Container.addSingleLineEdit(41,30,"CLINICACODIGO","Código","","ClinicaCodigo","svchar",0,"px",10,10,"left",null,[],41,"ClinicaCodigo",false,0,false,false);this.setGrid(this.Grid1Container);this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[8]={fld:"GROUP1",grid:0};this.GXValidFnc[9]={fld:"TABLE2",grid:0};
this.GXValidFnc[12]={fld:"TEXTBLOCKESPCODIGO",format:0,grid:0};this.GXValidFnc[14]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCESPCODIGO",gxz:"ZV6cEspCodigo",gxold:"OV6cEspCodigo",gxvar:"AV6cEspCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV6cEspCodigo=a},v2z:function(a){gx.O.ZV6cEspCodigo=a},v2c:function(){gx.fn.setControlValue("vCESPCODIGO",gx.O.AV6cEspCodigo,0)},c2v:function(){gx.O.AV6cEspCodigo=this.val()},val:function(){return gx.fn.getControlValue("vCESPCODIGO")
},nac:function(){return false}};this.GXValidFnc[17]={fld:"TEXTBLOCKESPDESCRIPCION",format:0,grid:0};this.GXValidFnc[19]={lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCESPDESCRIPCION",gxz:"ZV7cEspDescripcion",gxold:"OV7cEspDescripcion",gxvar:"AV7cEspDescripcion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7cEspDescripcion=a},v2z:function(a){gx.O.ZV7cEspDescripcion=a},v2c:function(){gx.fn.setControlValue("vCESPDESCRIPCION",gx.O.AV7cEspDescripcion,0)
},c2v:function(){gx.O.AV7cEspDescripcion=this.val()},val:function(){return gx.fn.getControlValue("vCESPDESCRIPCION")},nac:function(){return false}};this.GXValidFnc[22]={fld:"GROUP2",grid:0};this.GXValidFnc[23]={fld:"TABLE3",grid:0};this.GXValidFnc[27]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:26,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV5LinkSelection=a
},v2z:function(a){gx.O.ZV5LinkSelection=a},v2c:function(){},c2v:function(){gx.O.AV5LinkSelection=this.val()},val:function(){return gx.fn.getGridControlValue("vLINKSELECTION",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[28]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:26,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"ESPCODIGO",gxz:"Z17EspCodigo",gxold:"O17EspCodigo",gxvar:"A17EspCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A17EspCodigo=a
},v2z:function(a){gx.O.Z17EspCodigo=a},v2c:function(){gx.fn.setGridControlValue("ESPCODIGO",gx.fn.currentGridRowImpl(26),gx.O.A17EspCodigo,0)},c2v:function(){gx.O.A17EspCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("ESPCODIGO",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[29]={lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,grid:26,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"ESPDESCRIPCION",gxz:"Z18EspDescripcion",gxold:"O18EspDescripcion",gxvar:"A18EspDescripcion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A18EspDescripcion=a
},v2z:function(a){gx.O.Z18EspDescripcion=a},v2c:function(){gx.fn.setGridControlValue("ESPDESCRIPCION",gx.fn.currentGridRowImpl(26),gx.O.A18EspDescripcion,0)},c2v:function(){gx.O.A18EspDescripcion=this.val()},val:function(){return gx.fn.getGridControlValue("ESPDESCRIPCION",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[30]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:26,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CLINICACODIGO",gxz:"Z41ClinicaCodigo",gxold:"O41ClinicaCodigo",gxvar:"A41ClinicaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A41ClinicaCodigo=a
},v2z:function(a){gx.O.Z41ClinicaCodigo=a},v2c:function(){gx.fn.setGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(26),gx.O.A41ClinicaCodigo,0)},c2v:function(){gx.O.A41ClinicaCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[33]={fld:"TABLE4",grid:0};this.AV6cEspCodigo="";this.ZV6cEspCodigo="";this.OV6cEspCodigo="";this.AV7cEspDescripcion="";this.ZV7cEspDescripcion="";this.OV7cEspDescripcion="";
this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z17EspCodigo="";this.O17EspCodigo="";this.Z18EspDescripcion="";this.O18EspDescripcion="";this.Z41ClinicaCodigo="";this.O41ClinicaCodigo="";this.AV8pClinicaCodigo="";this.AV9pEspCodigo="";this.AV5LinkSelection="";this.A17EspCodigo="";this.A18EspDescripcion="";this.A41ClinicaCodigo="";this.ServerEvents=["e13112_client","e14111_client"];this.VarControlMap.AV8pClinicaCodigo={id:"vPCLINICACODIGO",grid:0,type:"svchar"};this.VarControlMap.AV9pEspCodigo={id:"vPESPCODIGO",grid:0,type:"svchar"};
this.VarControlMap.AV8pClinicaCodigo={id:"vPCLINICACODIGO",grid:0,type:"svchar"};this.Grid1Container.addRefreshingVar(this.GXValidFnc[14]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[19]);this.Grid1Container.addRefreshingVar({rfrVar:"AV8pClinicaCodigo"});this.SetStandaloneVars()}gx00v1.prototype=new gx.GxObject;gx.setParentObj(new gx00v1());