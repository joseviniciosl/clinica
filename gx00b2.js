gx.evt.autoSkip=false;function gx00b2(){this.ServerClass="Gx00B2";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=true;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV8pClinicaCodigo=gx.fn.getControlValue("vPCLINICACODIGO");this.AV9pCategoriaCodigo=gx.fn.getControlValue("vPCATEGORIACODIGO");this.AV10pSubCategoriaCodigo=gx.fn.getControlValue("vPSUBCATEGORIACODIGO")};this.e130h2_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e140h1_client=function(){this.executeServerEvent("CANCEL",true)
};this.GXValidFnc=[];this.GXCtrlIds=[2,8,9,12,14,17,19,22,23,27,28,29,30,31,34];this.GXLastCtrlId=34;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",26,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00b2",[],false,1,false,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");this.Grid1Container.addBitmap("&Linkselection","vLINKSELECTION",27,0,"px",17,"px",null,"","");this.Grid1Container.addSingleLineEdit(124,28,"SUBCATEGORIACODIGO","Categoría","","SubCategoriaCodigo","svchar",0,"px",10,10,"left",null,[],124,"SubCategoriaCodigo",true,0,false,false);
this.Grid1Container.addSingleLineEdit(125,29,"SUBCATEGORIADESCRIPCION","Descripción","Seleccionar","SubCategoriaDescripcion","svchar",0,"px",100,100,"left",null,[],125,"SubCategoriaDescripcion",true,0,false,false);this.Grid1Container.addSingleLineEdit(41,30,"CLINICACODIGO","Código","","ClinicaCodigo","svchar",0,"px",10,10,"left",null,[],41,"ClinicaCodigo",false,0,false,false);this.Grid1Container.addComboBox(27,31,"CATEGORIACODIGO","Categoría","CategoriaCodigo","svchar",null,0,false,false,0,"px");
this.setGrid(this.Grid1Container);this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[8]={fld:"GROUP1",grid:0};this.GXValidFnc[9]={fld:"TABLE2",grid:0};this.GXValidFnc[12]={fld:"TEXTBLOCKSUBCATEGORIACODIGO",format:0,grid:0};this.GXValidFnc[14]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCSUBCATEGORIACODIGO",gxz:"ZV6cSubCategoriaCodigo",gxold:"OV6cSubCategoriaCodigo",gxvar:"AV6cSubCategoriaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV6cSubCategoriaCodigo=a
},v2z:function(a){gx.O.ZV6cSubCategoriaCodigo=a},v2c:function(){gx.fn.setControlValue("vCSUBCATEGORIACODIGO",gx.O.AV6cSubCategoriaCodigo,0)},c2v:function(){gx.O.AV6cSubCategoriaCodigo=this.val()},val:function(){return gx.fn.getControlValue("vCSUBCATEGORIACODIGO")},nac:function(){return false}};this.GXValidFnc[17]={fld:"TEXTBLOCKSUBCATEGORIADESCRIPCION",format:0,grid:0};this.GXValidFnc[19]={lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCSUBCATEGORIADESCRIPCION",gxz:"ZV7cSubCategoriaDescripcion",gxold:"OV7cSubCategoriaDescripcion",gxvar:"AV7cSubCategoriaDescripcion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7cSubCategoriaDescripcion=a
},v2z:function(a){gx.O.ZV7cSubCategoriaDescripcion=a},v2c:function(){gx.fn.setControlValue("vCSUBCATEGORIADESCRIPCION",gx.O.AV7cSubCategoriaDescripcion,0)},c2v:function(){gx.O.AV7cSubCategoriaDescripcion=this.val()},val:function(){return gx.fn.getControlValue("vCSUBCATEGORIADESCRIPCION")},nac:function(){return false}};this.GXValidFnc[22]={fld:"GROUP2",grid:0};this.GXValidFnc[23]={fld:"TABLE3",grid:0};this.GXValidFnc[27]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:26,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV5LinkSelection=a
},v2z:function(a){gx.O.ZV5LinkSelection=a},v2c:function(){},c2v:function(){gx.O.AV5LinkSelection=this.val()},val:function(){return gx.fn.getGridControlValue("vLINKSELECTION",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[28]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:26,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"SUBCATEGORIACODIGO",gxz:"Z124SubCategoriaCodigo",gxold:"O124SubCategoriaCodigo",gxvar:"A124SubCategoriaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A124SubCategoriaCodigo=a
},v2z:function(a){gx.O.Z124SubCategoriaCodigo=a},v2c:function(){gx.fn.setGridControlValue("SUBCATEGORIACODIGO",gx.fn.currentGridRowImpl(26),gx.O.A124SubCategoriaCodigo,0)},c2v:function(){gx.O.A124SubCategoriaCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("SUBCATEGORIACODIGO",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[29]={lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,grid:26,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"SUBCATEGORIADESCRIPCION",gxz:"Z125SubCategoriaDescripcion",gxold:"O125SubCategoriaDescripcion",gxvar:"A125SubCategoriaDescripcion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A125SubCategoriaDescripcion=a
},v2z:function(a){gx.O.Z125SubCategoriaDescripcion=a},v2c:function(){gx.fn.setGridControlValue("SUBCATEGORIADESCRIPCION",gx.fn.currentGridRowImpl(26),gx.O.A125SubCategoriaDescripcion,0)},c2v:function(){gx.O.A125SubCategoriaDescripcion=this.val()},val:function(){return gx.fn.getGridControlValue("SUBCATEGORIADESCRIPCION",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[30]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:26,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CLINICACODIGO",gxz:"Z41ClinicaCodigo",gxold:"O41ClinicaCodigo",gxvar:"A41ClinicaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A41ClinicaCodigo=a
},v2z:function(a){gx.O.Z41ClinicaCodigo=a},v2c:function(){gx.fn.setGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(26),gx.O.A41ClinicaCodigo,0)},c2v:function(){gx.O.A41ClinicaCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[31]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:26,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CATEGORIACODIGO",gxz:"Z27CategoriaCodigo",gxold:"O27CategoriaCodigo",gxvar:"A27CategoriaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"dyncombo",v2v:function(a){gx.O.A27CategoriaCodigo=a
},v2z:function(a){gx.O.Z27CategoriaCodigo=a},v2c:function(){gx.fn.setGridComboBoxValue("CATEGORIACODIGO",gx.fn.currentGridRowImpl(26),gx.O.A27CategoriaCodigo)},c2v:function(){gx.O.A27CategoriaCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("CATEGORIACODIGO",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[34]={fld:"TABLE4",grid:0};this.AV6cSubCategoriaCodigo="";this.ZV6cSubCategoriaCodigo="";this.OV6cSubCategoriaCodigo="";this.AV7cSubCategoriaDescripcion="";
this.ZV7cSubCategoriaDescripcion="";this.OV7cSubCategoriaDescripcion="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z124SubCategoriaCodigo="";this.O124SubCategoriaCodigo="";this.Z125SubCategoriaDescripcion="";this.O125SubCategoriaDescripcion="";this.Z41ClinicaCodigo="";this.O41ClinicaCodigo="";this.Z27CategoriaCodigo="";this.O27CategoriaCodigo="";this.AV8pClinicaCodigo="";this.AV9pCategoriaCodigo="";this.AV10pSubCategoriaCodigo="";this.AV5LinkSelection="";this.A124SubCategoriaCodigo="";
this.A125SubCategoriaDescripcion="";this.A41ClinicaCodigo="";this.A27CategoriaCodigo="";this.ServerEvents=["e130h2_client","e140h1_client"];this.VarControlMap.AV8pClinicaCodigo={id:"vPCLINICACODIGO",grid:0,type:"svchar"};this.VarControlMap.AV9pCategoriaCodigo={id:"vPCATEGORIACODIGO",grid:0,type:"svchar"};this.VarControlMap.AV10pSubCategoriaCodigo={id:"vPSUBCATEGORIACODIGO",grid:0,type:"svchar"};this.VarControlMap.AV8pClinicaCodigo={id:"vPCLINICACODIGO",grid:0,type:"svchar"};this.VarControlMap.AV9pCategoriaCodigo={id:"vPCATEGORIACODIGO",grid:0,type:"svchar"};
this.Grid1Container.addRefreshingVar(this.GXValidFnc[14]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[19]);this.Grid1Container.addRefreshingVar({rfrVar:"AV8pClinicaCodigo"});this.Grid1Container.addRefreshingVar({rfrVar:"AV9pCategoriaCodigo"});this.SetStandaloneVars()}gx00b2.prototype=new gx.GxObject;gx.setParentObj(new gx00b2());