gx.evt.autoSkip=false;function gx00b0(){this.ServerClass="Gx00B0";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=true;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV10pClinicaCodigo=gx.fn.getControlValue("vPCLINICACODIGO");this.AV11pCategoriaCodigo=gx.fn.getControlValue("vPCATEGORIACODIGO");this.AV12pSubCategoriaCodigo=gx.fn.getControlValue("vPSUBCATEGORIACODIGO")};this.Valid_Clinicacodigo=function(){try{if(gx.fn.currentGridRowImpl(36)===0){return true
}var a=gx.util.balloon.getNew("CLINICACODIGO",gx.fn.currentGridRowImpl(36));this.AnyError=0;this.StandaloneModal();this.StandaloneNotModal()}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Categoriacodigo=function(){try{if(gx.fn.currentGridRowImpl(36)===0){return true}var a=gx.util.balloon.getNew("CATEGORIACODIGO",gx.fn.currentGridRowImpl(36));this.AnyError=0}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.e130i2_client=function(){this.executeServerEvent("ENTER",true,arguments[0])
};this.e140i1_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[2,8,9,12,14,17,19,22,24,27,29,32,33,37,38,39,40,41,42,45];this.GXLastCtrlId=45;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",36,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00b0",[],false,1,false,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");this.Grid1Container.addBitmap("&Linkselection","vLINKSELECTION",37,0,"px",17,"px",null,"","");
this.Grid1Container.addSingleLineEdit(41,38,"CLINICACODIGO","Código","","ClinicaCodigo","svchar",0,"px",10,10,"left",null,[],41,"ClinicaCodigo",true,0,false,false);this.Grid1Container.addSingleLineEdit(28,39,"CATEGORIADESCRIPCION","Descripción","","CategoriaDescripcion","svchar",0,"px",100,100,"left",null,[],28,"CategoriaDescripcion",true,0,false,false);this.Grid1Container.addSingleLineEdit(124,40,"SUBCATEGORIACODIGO","Categoría","","SubCategoriaCodigo","svchar",0,"px",10,10,"left",null,[],124,"SubCategoriaCodigo",true,0,false,false);
this.Grid1Container.addSingleLineEdit(125,41,"SUBCATEGORIADESCRIPCION","Descripción","Seleccionar","SubCategoriaDescripcion","svchar",0,"px",100,100,"left",null,[],125,"SubCategoriaDescripcion",true,0,false,false);this.Grid1Container.addComboBox(27,42,"CATEGORIACODIGO","Categoría","CategoriaCodigo","svchar",null,0,false,false,0,"px");this.setGrid(this.Grid1Container);this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[8]={fld:"GROUP1",grid:0};this.GXValidFnc[9]={fld:"TABLE2",grid:0};this.GXValidFnc[12]={fld:"TEXTBLOCKCLINICACODIGO",format:0,grid:0};
this.GXValidFnc[14]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCCLINICACODIGO",gxz:"ZV6cClinicaCodigo",gxold:"OV6cClinicaCodigo",gxvar:"AV6cClinicaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV6cClinicaCodigo=a},v2z:function(a){gx.O.ZV6cClinicaCodigo=a},v2c:function(){gx.fn.setControlValue("vCCLINICACODIGO",gx.O.AV6cClinicaCodigo,0)},c2v:function(){gx.O.AV6cClinicaCodigo=this.val()},val:function(){return gx.fn.getControlValue("vCCLINICACODIGO")
},nac:function(){return false}};this.GXValidFnc[17]={fld:"TEXTBLOCKCATEGORIADESCRIPCION",format:0,grid:0};this.GXValidFnc[19]={lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCCATEGORIADESCRIPCION",gxz:"ZV7cCategoriaDescripcion",gxold:"OV7cCategoriaDescripcion",gxvar:"AV7cCategoriaDescripcion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7cCategoriaDescripcion=a},v2z:function(a){gx.O.ZV7cCategoriaDescripcion=a},v2c:function(){gx.fn.setControlValue("vCCATEGORIADESCRIPCION",gx.O.AV7cCategoriaDescripcion,0)
},c2v:function(){gx.O.AV7cCategoriaDescripcion=this.val()},val:function(){return gx.fn.getControlValue("vCCATEGORIADESCRIPCION")},nac:function(){return false}};this.GXValidFnc[22]={fld:"TEXTBLOCKSUBCATEGORIACODIGO",format:0,grid:0};this.GXValidFnc[24]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCSUBCATEGORIACODIGO",gxz:"ZV8cSubCategoriaCodigo",gxold:"OV8cSubCategoriaCodigo",gxvar:"AV8cSubCategoriaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV8cSubCategoriaCodigo=a
},v2z:function(a){gx.O.ZV8cSubCategoriaCodigo=a},v2c:function(){gx.fn.setControlValue("vCSUBCATEGORIACODIGO",gx.O.AV8cSubCategoriaCodigo,0)},c2v:function(){gx.O.AV8cSubCategoriaCodigo=this.val()},val:function(){return gx.fn.getControlValue("vCSUBCATEGORIACODIGO")},nac:function(){return false}};this.GXValidFnc[27]={fld:"TEXTBLOCKSUBCATEGORIADESCRIPCION",format:0,grid:0};this.GXValidFnc[29]={lvl:0,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCSUBCATEGORIADESCRIPCION",gxz:"ZV9cSubCategoriaDescripcion",gxold:"OV9cSubCategoriaDescripcion",gxvar:"AV9cSubCategoriaDescripcion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV9cSubCategoriaDescripcion=a
},v2z:function(a){gx.O.ZV9cSubCategoriaDescripcion=a},v2c:function(){gx.fn.setControlValue("vCSUBCATEGORIADESCRIPCION",gx.O.AV9cSubCategoriaDescripcion,0)},c2v:function(){gx.O.AV9cSubCategoriaDescripcion=this.val()},val:function(){return gx.fn.getControlValue("vCSUBCATEGORIADESCRIPCION")},nac:function(){return false}};this.GXValidFnc[32]={fld:"GROUP2",grid:0};this.GXValidFnc[33]={fld:"TABLE3",grid:0};this.GXValidFnc[37]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV5LinkSelection=a
},v2z:function(a){gx.O.ZV5LinkSelection=a},v2c:function(){},c2v:function(){gx.O.AV5LinkSelection=this.val()},val:function(){return gx.fn.getGridControlValue("vLINKSELECTION",gx.fn.currentGridRowImpl(36))},nac:function(){return false}};this.GXValidFnc[38]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:this.Valid_Clinicacodigo,isvalid:null,fld:"CLINICACODIGO",gxz:"Z41ClinicaCodigo",gxold:"O41ClinicaCodigo",gxvar:"A41ClinicaCodigo",ucs:[],op:[39],ip:[39,42,38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A41ClinicaCodigo=a
},v2z:function(a){gx.O.Z41ClinicaCodigo=a},v2c:function(){gx.fn.setGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(36),gx.O.A41ClinicaCodigo,0)},c2v:function(){gx.O.A41ClinicaCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(36))},nac:function(){return false}};this.GXValidFnc[39]={lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CATEGORIADESCRIPCION",gxz:"Z28CategoriaDescripcion",gxold:"O28CategoriaDescripcion",gxvar:"A28CategoriaDescripcion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A28CategoriaDescripcion=a
},v2z:function(a){gx.O.Z28CategoriaDescripcion=a},v2c:function(){gx.fn.setGridControlValue("CATEGORIADESCRIPCION",gx.fn.currentGridRowImpl(36),gx.O.A28CategoriaDescripcion,0)},c2v:function(){gx.O.A28CategoriaDescripcion=this.val()},val:function(){return gx.fn.getGridControlValue("CATEGORIADESCRIPCION",gx.fn.currentGridRowImpl(36))},nac:function(){return false}};this.GXValidFnc[40]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"SUBCATEGORIACODIGO",gxz:"Z124SubCategoriaCodigo",gxold:"O124SubCategoriaCodigo",gxvar:"A124SubCategoriaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A124SubCategoriaCodigo=a
},v2z:function(a){gx.O.Z124SubCategoriaCodigo=a},v2c:function(){gx.fn.setGridControlValue("SUBCATEGORIACODIGO",gx.fn.currentGridRowImpl(36),gx.O.A124SubCategoriaCodigo,0)},c2v:function(){gx.O.A124SubCategoriaCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("SUBCATEGORIACODIGO",gx.fn.currentGridRowImpl(36))},nac:function(){return false}};this.GXValidFnc[41]={lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"SUBCATEGORIADESCRIPCION",gxz:"Z125SubCategoriaDescripcion",gxold:"O125SubCategoriaDescripcion",gxvar:"A125SubCategoriaDescripcion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A125SubCategoriaDescripcion=a
},v2z:function(a){gx.O.Z125SubCategoriaDescripcion=a},v2c:function(){gx.fn.setGridControlValue("SUBCATEGORIADESCRIPCION",gx.fn.currentGridRowImpl(36),gx.O.A125SubCategoriaDescripcion,0)},c2v:function(){gx.O.A125SubCategoriaDescripcion=this.val()},val:function(){return gx.fn.getGridControlValue("SUBCATEGORIADESCRIPCION",gx.fn.currentGridRowImpl(36))},nac:function(){return false}};this.GXValidFnc[42]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:this.Valid_Categoriacodigo,isvalid:null,fld:"CATEGORIACODIGO",gxz:"Z27CategoriaCodigo",gxold:"O27CategoriaCodigo",gxvar:"A27CategoriaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"dyncombo",v2v:function(a){gx.O.A27CategoriaCodigo=a
},v2z:function(a){gx.O.Z27CategoriaCodigo=a},v2c:function(){gx.fn.setGridComboBoxValue("CATEGORIACODIGO",gx.fn.currentGridRowImpl(36),gx.O.A27CategoriaCodigo)},c2v:function(){gx.O.A27CategoriaCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("CATEGORIACODIGO",gx.fn.currentGridRowImpl(36))},nac:function(){return false}};this.GXValidFnc[45]={fld:"TABLE4",grid:0};this.AV6cClinicaCodigo="";this.ZV6cClinicaCodigo="";this.OV6cClinicaCodigo="";this.AV7cCategoriaDescripcion="";this.ZV7cCategoriaDescripcion="";
this.OV7cCategoriaDescripcion="";this.AV8cSubCategoriaCodigo="";this.ZV8cSubCategoriaCodigo="";this.OV8cSubCategoriaCodigo="";this.AV9cSubCategoriaDescripcion="";this.ZV9cSubCategoriaDescripcion="";this.OV9cSubCategoriaDescripcion="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z41ClinicaCodigo="";this.O41ClinicaCodigo="";this.Z28CategoriaDescripcion="";this.O28CategoriaDescripcion="";this.Z124SubCategoriaCodigo="";this.O124SubCategoriaCodigo="";this.Z125SubCategoriaDescripcion="";this.O125SubCategoriaDescripcion="";
this.Z27CategoriaCodigo="";this.O27CategoriaCodigo="";this.AV10pClinicaCodigo="";this.AV11pCategoriaCodigo="";this.AV12pSubCategoriaCodigo="";this.AV5LinkSelection="";this.A41ClinicaCodigo="";this.A28CategoriaDescripcion="";this.A124SubCategoriaCodigo="";this.A125SubCategoriaDescripcion="";this.A27CategoriaCodigo="";this.ServerEvents=["e130i2_client","e140i1_client"];this.VarControlMap.AV10pClinicaCodigo={id:"vPCLINICACODIGO",grid:0,type:"svchar"};this.VarControlMap.AV11pCategoriaCodigo={id:"vPCATEGORIACODIGO",grid:0,type:"svchar"};
this.VarControlMap.AV12pSubCategoriaCodigo={id:"vPSUBCATEGORIACODIGO",grid:0,type:"svchar"};this.Grid1Container.addRefreshingVar(this.GXValidFnc[14]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[19]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[24]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[29]);this.SetStandaloneVars()}gx00b0.prototype=new gx.GxObject;gx.setParentObj(new gx00b0());