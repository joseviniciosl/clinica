gx.evt.autoSkip=false;function gx00c0(){this.ServerClass="Gx00C0";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=true;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV13pClinicaCodigo=gx.fn.getControlValue("vPCLINICACODIGO");this.AV14pArticuloCodigo=gx.fn.getControlValue("vPARTICULOCODIGO")};this.e130j2_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e140j1_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];
this.GXCtrlIds=[2,8,9,12,14,17,19,22,24,27,29,32,34,37,39,42,44,47,48,52,53,54,55,56,59];this.GXLastCtrlId=59;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",51,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00c0",[],false,1,false,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");this.Grid1Container.addBitmap("&Linkselection","vLINKSELECTION",52,0,"px",17,"px",null,"","");this.Grid1Container.addSingleLineEdit(41,53,"CLINICACODIGO","Código","","ClinicaCodigo","svchar",0,"px",10,10,"left",null,[],41,"ClinicaCodigo",true,0,false,false);
this.Grid1Container.addSingleLineEdit(30,54,"ARTICULOCODIGO","Artículo","","ArticuloCodigo","svchar",0,"px",10,10,"left",null,[],30,"ArticuloCodigo",true,0,false,false);this.Grid1Container.addSingleLineEdit(31,55,"ARTICULODESCRIPCION","Artículo","Seleccionar","ArticuloDescripcion","svchar",0,"px",100,100,"left",null,[],31,"ArticuloDescripcion",true,0,false,false);this.Grid1Container.addComboBox(33,56,"ARTICULOTIPO","Tipo","ArticuloTipo","int",null,0,true,false,0,"px");this.setGrid(this.Grid1Container);
this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[8]={fld:"GROUP1",grid:0};this.GXValidFnc[9]={fld:"TABLE2",grid:0};this.GXValidFnc[12]={fld:"TEXTBLOCKCLINICACODIGO",format:0,grid:0};this.GXValidFnc[14]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCCLINICACODIGO",gxz:"ZV6cClinicaCodigo",gxold:"OV6cClinicaCodigo",gxvar:"AV6cClinicaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV6cClinicaCodigo=a},v2z:function(a){gx.O.ZV6cClinicaCodigo=a
},v2c:function(){gx.fn.setControlValue("vCCLINICACODIGO",gx.O.AV6cClinicaCodigo,0)},c2v:function(){gx.O.AV6cClinicaCodigo=this.val()},val:function(){return gx.fn.getControlValue("vCCLINICACODIGO")},nac:function(){return false}};this.GXValidFnc[17]={fld:"TEXTBLOCKARTICULOCODIGO",format:0,grid:0};this.GXValidFnc[19]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCARTICULOCODIGO",gxz:"ZV7cArticuloCodigo",gxold:"OV7cArticuloCodigo",gxvar:"AV7cArticuloCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7cArticuloCodigo=a
},v2z:function(a){gx.O.ZV7cArticuloCodigo=a},v2c:function(){gx.fn.setControlValue("vCARTICULOCODIGO",gx.O.AV7cArticuloCodigo,0)},c2v:function(){gx.O.AV7cArticuloCodigo=this.val()},val:function(){return gx.fn.getControlValue("vCARTICULOCODIGO")},nac:function(){return false}};this.GXValidFnc[22]={fld:"TEXTBLOCKARTICULODESCRIPCION",format:0,grid:0};this.GXValidFnc[24]={lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCARTICULODESCRIPCION",gxz:"ZV8cArticuloDescripcion",gxold:"OV8cArticuloDescripcion",gxvar:"AV8cArticuloDescripcion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV8cArticuloDescripcion=a
},v2z:function(a){gx.O.ZV8cArticuloDescripcion=a},v2c:function(){gx.fn.setControlValue("vCARTICULODESCRIPCION",gx.O.AV8cArticuloDescripcion,0)},c2v:function(){gx.O.AV8cArticuloDescripcion=this.val()},val:function(){return gx.fn.getControlValue("vCARTICULODESCRIPCION")},nac:function(){return false}};this.GXValidFnc[27]={fld:"TEXTBLOCKARTICULOPRECIO",format:0,grid:0};this.GXValidFnc[29]={lvl:0,type:"decimal",len:17,dec:2,sign:false,pic:"ZZZZZZZZZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCARTICULOPRECIO",gxz:"ZV9cArticuloPrecio",gxold:"OV9cArticuloPrecio",gxvar:"AV9cArticuloPrecio",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV9cArticuloPrecio=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.ZV9cArticuloPrecio=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setDecimalValue("vCARTICULOPRECIO",gx.O.AV9cArticuloPrecio,2,".")},c2v:function(){gx.O.AV9cArticuloPrecio=this.val()},val:function(){return gx.fn.getDecimalValue("vCARTICULOPRECIO",",",".")},nac:function(){return false}};this.GXValidFnc[32]={fld:"TEXTBLOCKARTICULOCOSTO",format:0,grid:0};this.GXValidFnc[34]={lvl:0,type:"decimal",len:17,dec:2,sign:false,pic:"ZZZZZZZZZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCARTICULOCOSTO",gxz:"ZV10cArticuloCosto",gxold:"OV10cArticuloCosto",gxvar:"AV10cArticuloCosto",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV10cArticuloCosto=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.ZV10cArticuloCosto=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setDecimalValue("vCARTICULOCOSTO",gx.O.AV10cArticuloCosto,2,".")},c2v:function(){gx.O.AV10cArticuloCosto=this.val()},val:function(){return gx.fn.getDecimalValue("vCARTICULOCOSTO",",",".")},nac:function(){return false}};this.GXValidFnc[37]={fld:"TEXTBLOCKCATEGORIACODIGO",format:0,grid:0};this.GXValidFnc[39]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCCATEGORIACODIGO",gxz:"ZV15cCategoriaCodigo",gxold:"OV15cCategoriaCodigo",gxvar:"AV15cCategoriaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"dyncombo",v2v:function(a){gx.O.AV15cCategoriaCodigo=a
},v2z:function(a){gx.O.ZV15cCategoriaCodigo=a},v2c:function(){gx.fn.setComboBoxValue("vCCATEGORIACODIGO",gx.O.AV15cCategoriaCodigo)},c2v:function(){gx.O.AV15cCategoriaCodigo=this.val()},val:function(){return gx.fn.getControlValue("vCCATEGORIACODIGO")},nac:function(){return false}};this.GXValidFnc[42]={fld:"TEXTBLOCKSUBCATEGORIACODIGO",format:0,grid:0};this.GXValidFnc[44]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCSUBCATEGORIACODIGO",gxz:"ZV12cSubCategoriaCodigo",gxold:"OV12cSubCategoriaCodigo",gxvar:"AV12cSubCategoriaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV12cSubCategoriaCodigo=a
},v2z:function(a){gx.O.ZV12cSubCategoriaCodigo=a},v2c:function(){gx.fn.setControlValue("vCSUBCATEGORIACODIGO",gx.O.AV12cSubCategoriaCodigo,0)},c2v:function(){gx.O.AV12cSubCategoriaCodigo=this.val()},val:function(){return gx.fn.getControlValue("vCSUBCATEGORIACODIGO")},nac:function(){return false}};this.GXValidFnc[47]={fld:"GROUP2",grid:0};this.GXValidFnc[48]={fld:"TABLE3",grid:0};this.GXValidFnc[52]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV5LinkSelection=a
},v2z:function(a){gx.O.ZV5LinkSelection=a},v2c:function(){},c2v:function(){gx.O.AV5LinkSelection=this.val()},val:function(){return gx.fn.getGridControlValue("vLINKSELECTION",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[53]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CLINICACODIGO",gxz:"Z41ClinicaCodigo",gxold:"O41ClinicaCodigo",gxvar:"A41ClinicaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A41ClinicaCodigo=a
},v2z:function(a){gx.O.Z41ClinicaCodigo=a},v2c:function(){gx.fn.setGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(51),gx.O.A41ClinicaCodigo,0)},c2v:function(){gx.O.A41ClinicaCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[54]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"ARTICULOCODIGO",gxz:"Z30ArticuloCodigo",gxold:"O30ArticuloCodigo",gxvar:"A30ArticuloCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A30ArticuloCodigo=a
},v2z:function(a){gx.O.Z30ArticuloCodigo=a},v2c:function(){gx.fn.setGridControlValue("ARTICULOCODIGO",gx.fn.currentGridRowImpl(51),gx.O.A30ArticuloCodigo,0)},c2v:function(){gx.O.A30ArticuloCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("ARTICULOCODIGO",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[55]={lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"ARTICULODESCRIPCION",gxz:"Z31ArticuloDescripcion",gxold:"O31ArticuloDescripcion",gxvar:"A31ArticuloDescripcion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A31ArticuloDescripcion=a
},v2z:function(a){gx.O.Z31ArticuloDescripcion=a},v2c:function(){gx.fn.setGridControlValue("ARTICULODESCRIPCION",gx.fn.currentGridRowImpl(51),gx.O.A31ArticuloDescripcion,0)},c2v:function(){gx.O.A31ArticuloDescripcion=this.val()},val:function(){return gx.fn.getGridControlValue("ARTICULODESCRIPCION",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[56]={lvl:2,type:"int",len:1,dec:0,sign:false,pic:"9",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOTIPO",gxz:"Z33ArticuloTipo",gxold:"O33ArticuloTipo",gxvar:"A33ArticuloTipo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.A33ArticuloTipo=gx.num.intval(a)
},v2z:function(a){gx.O.Z33ArticuloTipo=gx.num.intval(a)},v2c:function(){gx.fn.setGridComboBoxValue("ARTICULOTIPO",gx.fn.currentGridRowImpl(51),gx.O.A33ArticuloTipo)},c2v:function(){gx.O.A33ArticuloTipo=this.val()},val:function(){return gx.fn.getGridIntegerValue("ARTICULOTIPO",gx.fn.currentGridRowImpl(51),",")},nac:function(){return false}};this.GXValidFnc[59]={fld:"TABLE4",grid:0};this.AV6cClinicaCodigo="";this.ZV6cClinicaCodigo="";this.OV6cClinicaCodigo="";this.AV7cArticuloCodigo="";this.ZV7cArticuloCodigo="";
this.OV7cArticuloCodigo="";this.AV8cArticuloDescripcion="";this.ZV8cArticuloDescripcion="";this.OV8cArticuloDescripcion="";this.AV9cArticuloPrecio=0;this.ZV9cArticuloPrecio=0;this.OV9cArticuloPrecio=0;this.AV10cArticuloCosto=0;this.ZV10cArticuloCosto=0;this.OV10cArticuloCosto=0;this.AV15cCategoriaCodigo="";this.ZV15cCategoriaCodigo="";this.OV15cCategoriaCodigo="";this.AV12cSubCategoriaCodigo="";this.ZV12cSubCategoriaCodigo="";this.OV12cSubCategoriaCodigo="";this.ZV5LinkSelection="";this.OV5LinkSelection="";
this.Z41ClinicaCodigo="";this.O41ClinicaCodigo="";this.Z30ArticuloCodigo="";this.O30ArticuloCodigo="";this.Z31ArticuloDescripcion="";this.O31ArticuloDescripcion="";this.Z33ArticuloTipo=0;this.O33ArticuloTipo=0;this.AV13pClinicaCodigo="";this.AV14pArticuloCodigo="";this.A32ArticuloPrecio=0;this.A60ArticuloCosto=0;this.A27CategoriaCodigo="";this.A124SubCategoriaCodigo="";this.AV5LinkSelection="";this.A41ClinicaCodigo="";this.A30ArticuloCodigo="";this.A31ArticuloDescripcion="";this.A33ArticuloTipo=0;
this.ServerEvents=["e130j2_client","e140j1_client"];this.VarControlMap.AV13pClinicaCodigo={id:"vPCLINICACODIGO",grid:0,type:"svchar"};this.VarControlMap.AV14pArticuloCodigo={id:"vPARTICULOCODIGO",grid:0,type:"svchar"};this.Grid1Container.addRefreshingVar(this.GXValidFnc[14]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[19]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[24]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[29]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[34]);
this.Grid1Container.addRefreshingVar(this.GXValidFnc[39]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[44]);this.SetStandaloneVars()}gx00c0.prototype=new gx.GxObject;gx.setParentObj(new gx00c0());