gx.evt.autoSkip=false;function gx0112(){this.ServerClass="Gx0112";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=true;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV8pClinicaCodigo=gx.fn.getControlValue("vPCLINICACODIGO");this.AV9pCajaCodigo=gx.fn.getControlValue("vPCAJACODIGO");this.AV10pCajaAnio=gx.fn.getIntegerValue("vPCAJAANIO",",")};this.e13182_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e14181_client=function(){this.executeServerEvent("CANCEL",true)
};this.GXValidFnc=[];this.GXCtrlIds=[2,8,9,12,14,17,19,22,23,27,28,29,30,31,34];this.GXLastCtrlId=34;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",26,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0112",[],false,1,false,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");this.Grid1Container.addBitmap("&Linkselection","vLINKSELECTION",27,0,"px",17,"px",null,"","");this.Grid1Container.addSingleLineEdit(135,28,"CAJAANIO","Anio","","CajaAnio","int",0,"px",4,4,"right",null,[],135,"CajaAnio",true,0,false,false);
this.Grid1Container.addSingleLineEdit(136,29,"CAJASIGUIENTE","Siguiente","Seleccionar","CajaSiguiente","int",0,"px",9,9,"right",null,[],136,"CajaSiguiente",true,0,false,false);this.Grid1Container.addSingleLineEdit(41,30,"CLINICACODIGO","Código","","ClinicaCodigo","svchar",0,"px",10,10,"left",null,[],41,"ClinicaCodigo",false,0,false,false);this.Grid1Container.addSingleLineEdit(132,31,"CAJACODIGO","Caja","","CajaCodigo","svchar",0,"px",10,10,"left",null,[],132,"CajaCodigo",false,0,false,false);this.setGrid(this.Grid1Container);
this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[8]={fld:"GROUP1",grid:0};this.GXValidFnc[9]={fld:"TABLE2",grid:0};this.GXValidFnc[12]={fld:"TEXTBLOCKCAJAANIO",format:0,grid:0};this.GXValidFnc[14]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCCAJAANIO",gxz:"ZV6cCajaAnio",gxold:"OV6cCajaAnio",gxvar:"AV6cCajaAnio",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV6cCajaAnio=gx.num.intval(a)
},v2z:function(a){gx.O.ZV6cCajaAnio=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCCAJAANIO",gx.O.AV6cCajaAnio,0)},c2v:function(){gx.O.AV6cCajaAnio=this.val()},val:function(){return gx.fn.getIntegerValue("vCCAJAANIO",",")},nac:function(){return false}};this.GXValidFnc[17]={fld:"TEXTBLOCKCAJASIGUIENTE",format:0,grid:0};this.GXValidFnc[19]={lvl:0,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCCAJASIGUIENTE",gxz:"ZV7cCajaSiguiente",gxold:"OV7cCajaSiguiente",gxvar:"AV7cCajaSiguiente",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7cCajaSiguiente=gx.num.intval(a)
},v2z:function(a){gx.O.ZV7cCajaSiguiente=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCCAJASIGUIENTE",gx.O.AV7cCajaSiguiente,0)},c2v:function(){gx.O.AV7cCajaSiguiente=this.val()},val:function(){return gx.fn.getIntegerValue("vCCAJASIGUIENTE",",")},nac:function(){return false}};this.GXValidFnc[22]={fld:"GROUP2",grid:0};this.GXValidFnc[23]={fld:"TABLE3",grid:0};this.GXValidFnc[27]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:26,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV5LinkSelection=a
},v2z:function(a){gx.O.ZV5LinkSelection=a},v2c:function(){},c2v:function(){gx.O.AV5LinkSelection=this.val()},val:function(){return gx.fn.getGridControlValue("vLINKSELECTION",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[28]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:26,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"CAJAANIO",gxz:"Z135CajaAnio",gxold:"O135CajaAnio",gxvar:"A135CajaAnio",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A135CajaAnio=gx.num.intval(a)
},v2z:function(a){gx.O.Z135CajaAnio=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("CAJAANIO",gx.fn.currentGridRowImpl(26),gx.O.A135CajaAnio,0)},c2v:function(){gx.O.A135CajaAnio=this.val()},val:function(){return gx.fn.getGridIntegerValue("CAJAANIO",gx.fn.currentGridRowImpl(26),",")},nac:function(){return false}};this.GXValidFnc[29]={lvl:2,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:1,grid:26,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"CAJASIGUIENTE",gxz:"Z136CajaSiguiente",gxold:"O136CajaSiguiente",gxvar:"A136CajaSiguiente",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A136CajaSiguiente=gx.num.intval(a)
},v2z:function(a){gx.O.Z136CajaSiguiente=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("CAJASIGUIENTE",gx.fn.currentGridRowImpl(26),gx.O.A136CajaSiguiente,0)},c2v:function(){gx.O.A136CajaSiguiente=this.val()},val:function(){return gx.fn.getGridIntegerValue("CAJASIGUIENTE",gx.fn.currentGridRowImpl(26),",")},nac:function(){return false}};this.GXValidFnc[30]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:26,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CLINICACODIGO",gxz:"Z41ClinicaCodigo",gxold:"O41ClinicaCodigo",gxvar:"A41ClinicaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A41ClinicaCodigo=a
},v2z:function(a){gx.O.Z41ClinicaCodigo=a},v2c:function(){gx.fn.setGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(26),gx.O.A41ClinicaCodigo,0)},c2v:function(){gx.O.A41ClinicaCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[31]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:26,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CAJACODIGO",gxz:"Z132CajaCodigo",gxold:"O132CajaCodigo",gxvar:"A132CajaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A132CajaCodigo=a
},v2z:function(a){gx.O.Z132CajaCodigo=a},v2c:function(){gx.fn.setGridControlValue("CAJACODIGO",gx.fn.currentGridRowImpl(26),gx.O.A132CajaCodigo,0)},c2v:function(){gx.O.A132CajaCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("CAJACODIGO",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[34]={fld:"TABLE4",grid:0};this.AV6cCajaAnio=0;this.ZV6cCajaAnio=0;this.OV6cCajaAnio=0;this.AV7cCajaSiguiente=0;this.ZV7cCajaSiguiente=0;this.OV7cCajaSiguiente=0;this.ZV5LinkSelection="";
this.OV5LinkSelection="";this.Z135CajaAnio=0;this.O135CajaAnio=0;this.Z136CajaSiguiente=0;this.O136CajaSiguiente=0;this.Z41ClinicaCodigo="";this.O41ClinicaCodigo="";this.Z132CajaCodigo="";this.O132CajaCodigo="";this.AV8pClinicaCodigo="";this.AV9pCajaCodigo="";this.AV10pCajaAnio=0;this.AV5LinkSelection="";this.A135CajaAnio=0;this.A136CajaSiguiente=0;this.A41ClinicaCodigo="";this.A132CajaCodigo="";this.ServerEvents=["e13182_client","e14181_client"];this.VarControlMap.AV8pClinicaCodigo={id:"vPCLINICACODIGO",grid:0,type:"svchar"};
this.VarControlMap.AV9pCajaCodigo={id:"vPCAJACODIGO",grid:0,type:"svchar"};this.VarControlMap.AV10pCajaAnio={id:"vPCAJAANIO",grid:0,type:"int"};this.VarControlMap.AV8pClinicaCodigo={id:"vPCLINICACODIGO",grid:0,type:"svchar"};this.VarControlMap.AV9pCajaCodigo={id:"vPCAJACODIGO",grid:0,type:"svchar"};this.Grid1Container.addRefreshingVar(this.GXValidFnc[14]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[19]);this.Grid1Container.addRefreshingVar({rfrVar:"AV8pClinicaCodigo"});this.Grid1Container.addRefreshingVar({rfrVar:"AV9pCajaCodigo"});
this.SetStandaloneVars()}gx0112.prototype=new gx.GxObject;gx.setParentObj(new gx0112());