gx.evt.autoSkip=false;function gx0210(){this.ServerClass="Gx0210";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=true;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV9pClinicaCodigo=gx.fn.getControlValue("vPCLINICACODIGO");this.AV10pReligionId=gx.fn.getIntegerValue("vPRELIGIONID",",")};this.e133e2_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e143e1_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];
this.GXCtrlIds=[2,8,9,12,14,17,19,22,24,27,28,32,33,34,35,38];this.GXLastCtrlId=38;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",31,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0210",[],false,1,false,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");this.Grid1Container.addBitmap("&Linkselection","vLINKSELECTION",32,0,"px",17,"px",null,"","");this.Grid1Container.addSingleLineEdit(41,33,"CLINICACODIGO","Código","","ClinicaCodigo","svchar",0,"px",10,10,"left",null,[],41,"ClinicaCodigo",true,0,false,false);
this.Grid1Container.addSingleLineEdit(315,34,"RELIGIONID","Religión","","ReligionId","int",0,"px",9,9,"right",null,[],315,"ReligionId",true,0,false,false);this.Grid1Container.addSingleLineEdit(316,35,"RELIGIONNOMBRE","Nombre","Seleccionar","ReligionNombre","svchar",0,"px",70,70,"left",null,[],316,"ReligionNombre",true,0,false,false);this.setGrid(this.Grid1Container);this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[8]={fld:"GROUP1",grid:0};this.GXValidFnc[9]={fld:"TABLE2",grid:0};this.GXValidFnc[12]={fld:"TEXTBLOCKCLINICACODIGO",format:0,grid:0};
this.GXValidFnc[14]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCCLINICACODIGO",gxz:"ZV6cClinicaCodigo",gxold:"OV6cClinicaCodigo",gxvar:"AV6cClinicaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV6cClinicaCodigo=a},v2z:function(a){gx.O.ZV6cClinicaCodigo=a},v2c:function(){gx.fn.setControlValue("vCCLINICACODIGO",gx.O.AV6cClinicaCodigo,0)},c2v:function(){gx.O.AV6cClinicaCodigo=this.val()},val:function(){return gx.fn.getControlValue("vCCLINICACODIGO")
},nac:function(){return false}};this.GXValidFnc[17]={fld:"TEXTBLOCKRELIGIONID",format:0,grid:0};this.GXValidFnc[19]={lvl:0,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCRELIGIONID",gxz:"ZV7cReligionId",gxold:"OV7cReligionId",gxvar:"AV7cReligionId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7cReligionId=gx.num.intval(a)},v2z:function(a){gx.O.ZV7cReligionId=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCRELIGIONID",gx.O.AV7cReligionId,0)
},c2v:function(){gx.O.AV7cReligionId=this.val()},val:function(){return gx.fn.getIntegerValue("vCRELIGIONID",",")},nac:function(){return false}};this.GXValidFnc[22]={fld:"TEXTBLOCKRELIGIONNOMBRE",format:0,grid:0};this.GXValidFnc[24]={lvl:0,type:"svchar",len:70,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCRELIGIONNOMBRE",gxz:"ZV8cReligionNombre",gxold:"OV8cReligionNombre",gxvar:"AV8cReligionNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV8cReligionNombre=a
},v2z:function(a){gx.O.ZV8cReligionNombre=a},v2c:function(){gx.fn.setControlValue("vCRELIGIONNOMBRE",gx.O.AV8cReligionNombre,0)},c2v:function(){gx.O.AV8cReligionNombre=this.val()},val:function(){return gx.fn.getControlValue("vCRELIGIONNOMBRE")},nac:function(){return false}};this.GXValidFnc[27]={fld:"GROUP2",grid:0};this.GXValidFnc[28]={fld:"TABLE3",grid:0};this.GXValidFnc[32]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:31,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV5LinkSelection=a
},v2z:function(a){gx.O.ZV5LinkSelection=a},v2c:function(){},c2v:function(){gx.O.AV5LinkSelection=this.val()},val:function(){return gx.fn.getGridControlValue("vLINKSELECTION",gx.fn.currentGridRowImpl(31))},nac:function(){return false}};this.GXValidFnc[33]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:31,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CLINICACODIGO",gxz:"Z41ClinicaCodigo",gxold:"O41ClinicaCodigo",gxvar:"A41ClinicaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A41ClinicaCodigo=a
},v2z:function(a){gx.O.Z41ClinicaCodigo=a},v2c:function(){gx.fn.setGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(31),gx.O.A41ClinicaCodigo,0)},c2v:function(){gx.O.A41ClinicaCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(31))},nac:function(){return false}};this.GXValidFnc[34]={lvl:2,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:1,grid:31,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"RELIGIONID",gxz:"Z315ReligionId",gxold:"O315ReligionId",gxvar:"A315ReligionId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A315ReligionId=gx.num.intval(a)
},v2z:function(a){gx.O.Z315ReligionId=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("RELIGIONID",gx.fn.currentGridRowImpl(31),gx.O.A315ReligionId,0)},c2v:function(){gx.O.A315ReligionId=this.val()},val:function(){return gx.fn.getGridIntegerValue("RELIGIONID",gx.fn.currentGridRowImpl(31),",")},nac:function(){return false}};this.GXValidFnc[35]={lvl:2,type:"svchar",len:70,dec:0,sign:false,ro:1,grid:31,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"RELIGIONNOMBRE",gxz:"Z316ReligionNombre",gxold:"O316ReligionNombre",gxvar:"A316ReligionNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A316ReligionNombre=a
},v2z:function(a){gx.O.Z316ReligionNombre=a},v2c:function(){gx.fn.setGridControlValue("RELIGIONNOMBRE",gx.fn.currentGridRowImpl(31),gx.O.A316ReligionNombre,0)},c2v:function(){gx.O.A316ReligionNombre=this.val()},val:function(){return gx.fn.getGridControlValue("RELIGIONNOMBRE",gx.fn.currentGridRowImpl(31))},nac:function(){return false}};this.GXValidFnc[38]={fld:"TABLE4",grid:0};this.AV6cClinicaCodigo="";this.ZV6cClinicaCodigo="";this.OV6cClinicaCodigo="";this.AV7cReligionId=0;this.ZV7cReligionId=0;
this.OV7cReligionId=0;this.AV8cReligionNombre="";this.ZV8cReligionNombre="";this.OV8cReligionNombre="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z41ClinicaCodigo="";this.O41ClinicaCodigo="";this.Z315ReligionId=0;this.O315ReligionId=0;this.Z316ReligionNombre="";this.O316ReligionNombre="";this.AV9pClinicaCodigo="";this.AV10pReligionId=0;this.AV5LinkSelection="";this.A41ClinicaCodigo="";this.A315ReligionId=0;this.A316ReligionNombre="";this.ServerEvents=["e133e2_client","e143e1_client"];
this.VarControlMap.AV9pClinicaCodigo={id:"vPCLINICACODIGO",grid:0,type:"svchar"};this.VarControlMap.AV10pReligionId={id:"vPRELIGIONID",grid:0,type:"int"};this.Grid1Container.addRefreshingVar(this.GXValidFnc[14]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[19]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[24]);this.SetStandaloneVars()}gx0210.prototype=new gx.GxObject;gx.setParentObj(new gx0210());