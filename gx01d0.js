gx.evt.autoSkip=false;function gx01d0(){this.ServerClass="Gx01D0";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=true;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV13pClinicaCodigo=gx.fn.getControlValue("vPCLINICACODIGO");this.AV14pFacturaId=gx.fn.getIntegerValue("vPFACTURAID",",")};this.e131u2_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e141u1_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];
this.GXCtrlIds=[2,8,9,12,14,17,19,22,24,27,29,32,34,37,39,42,44,47,48,52,53,54,55,56,57,58,59,60,61,62,63,66];this.GXLastCtrlId=66;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",51,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx01d0",[],false,1,false,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");this.Grid1Container.addBitmap("&Linkselection","vLINKSELECTION",52,0,"px",17,"px",null,"","");this.Grid1Container.addSingleLineEdit(41,53,"CLINICACODIGO","Código","","ClinicaCodigo","svchar",0,"px",10,10,"left",null,[],41,"ClinicaCodigo",true,0,false,false);
this.Grid1Container.addSingleLineEdit(185,54,"FACTURAID","Factura","","FacturaId","int",0,"px",9,9,"right",null,[],185,"FacturaId",true,0,false,false);this.Grid1Container.addSingleLineEdit(186,55,"FACTURAFECHA","Fecha","Seleccionar","FacturaFecha","date",0,"px",8,8,"right",null,[],186,"FacturaFecha",true,0,false,false);this.Grid1Container.addSingleLineEdit(187,56,"FACTURAHORA","Hora","","FacturaHora","char",0,"px",8,8,"left",null,[],187,"FacturaHora",true,0,false,false);this.Grid1Container.addComboBox(188,57,"FACTURAESTADO","Estado","FacturaEstado","int",null,0,true,false,0,"px");
this.Grid1Container.addSingleLineEdit(178,58,"CLIENTECODIGO","Cliente","","ClienteCodigo","svchar",0,"px",10,10,"left",null,[],178,"ClienteCodigo",true,0,false,false);this.Grid1Container.addSingleLineEdit(189,59,"FACTURADOCTO","Documento","","FacturaDocto","int",0,"px",9,9,"right",null,[],189,"FacturaDocto",true,0,false,false);this.Grid1Container.addSingleLineEdit(190,60,"FACTURASERIE","Serie","","FacturaSerie","svchar",0,"px",20,20,"left",null,[],190,"FacturaSerie",true,0,false,false);this.Grid1Container.addSingleLineEdit(191,61,"FACTURAIVA","IVA","","FacturaIva","decimal",0,"px",17,17,"right",null,[],191,"FacturaIva",true,2,false,false);
this.Grid1Container.addSingleLineEdit(91,62,"CONSULTAID","Consulta","","ConsultaId","int",0,"px",9,9,"right",null,[],91,"ConsultaId",true,0,false,false);this.Grid1Container.addSingleLineEdit(132,63,"CAJACODIGO","Caja","","CajaCodigo","svchar",0,"px",10,10,"left",null,[],132,"CajaCodigo",true,0,false,false);this.setGrid(this.Grid1Container);this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[8]={fld:"GROUP1",grid:0};this.GXValidFnc[9]={fld:"TABLE2",grid:0};this.GXValidFnc[12]={fld:"TEXTBLOCKCLINICACODIGO",format:0,grid:0};
this.GXValidFnc[14]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCCLINICACODIGO",gxz:"ZV6cClinicaCodigo",gxold:"OV6cClinicaCodigo",gxvar:"AV6cClinicaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV6cClinicaCodigo=a},v2z:function(a){gx.O.ZV6cClinicaCodigo=a},v2c:function(){gx.fn.setControlValue("vCCLINICACODIGO",gx.O.AV6cClinicaCodigo,0)},c2v:function(){gx.O.AV6cClinicaCodigo=this.val()},val:function(){return gx.fn.getControlValue("vCCLINICACODIGO")
},nac:function(){return false}};this.GXValidFnc[17]={fld:"TEXTBLOCKFACTURAID",format:0,grid:0};this.GXValidFnc[19]={lvl:0,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCFACTURAID",gxz:"ZV7cFacturaId",gxold:"OV7cFacturaId",gxvar:"AV7cFacturaId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7cFacturaId=gx.num.intval(a)},v2z:function(a){gx.O.ZV7cFacturaId=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCFACTURAID",gx.O.AV7cFacturaId,0)
},c2v:function(){gx.O.AV7cFacturaId=this.val()},val:function(){return gx.fn.getIntegerValue("vCFACTURAID",",")},nac:function(){return false}};this.GXValidFnc[22]={fld:"TEXTBLOCKFACTURAFECHA",format:0,grid:0};this.GXValidFnc[24]={lvl:0,type:"date",len:8,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCFACTURAFECHA",gxz:"ZV8cFacturaFecha",gxold:"OV8cFacturaFecha",gxvar:"AV8cFacturaFecha",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV8cFacturaFecha=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.ZV8cFacturaFecha=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setControlValue("vCFACTURAFECHA",gx.O.AV8cFacturaFecha,0)},c2v:function(){gx.O.AV8cFacturaFecha=this.val()},val:function(){return gx.fn.getControlValue("vCFACTURAFECHA")},nac:function(){return false}};this.GXValidFnc[27]={fld:"TEXTBLOCKFACTURAHORA",format:0,grid:0};this.GXValidFnc[29]={lvl:0,type:"char",len:8,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCFACTURAHORA",gxz:"ZV9cFacturaHora",gxold:"OV9cFacturaHora",gxvar:"AV9cFacturaHora",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV9cFacturaHora=a
},v2z:function(a){gx.O.ZV9cFacturaHora=a},v2c:function(){gx.fn.setControlValue("vCFACTURAHORA",gx.O.AV9cFacturaHora,0)},c2v:function(){gx.O.AV9cFacturaHora=this.val()},val:function(){return gx.fn.getControlValue("vCFACTURAHORA")},nac:function(){return false}};this.GXValidFnc[32]={fld:"TEXTBLOCKFACTURAESTADO",format:0,grid:0};this.GXValidFnc[34]={lvl:0,type:"int",len:1,dec:0,sign:false,pic:"9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCFACTURAESTADO",gxz:"ZV10cFacturaEstado",gxold:"OV10cFacturaEstado",gxvar:"AV10cFacturaEstado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.AV10cFacturaEstado=gx.num.intval(a)
},v2z:function(a){gx.O.ZV10cFacturaEstado=gx.num.intval(a)},v2c:function(){gx.fn.setComboBoxValue("vCFACTURAESTADO",gx.O.AV10cFacturaEstado)},c2v:function(){gx.O.AV10cFacturaEstado=this.val()},val:function(){return gx.fn.getIntegerValue("vCFACTURAESTADO",",")},nac:function(){return false}};this.GXValidFnc[37]={fld:"TEXTBLOCKCLIENTECODIGO",format:0,grid:0};this.GXValidFnc[39]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCCLIENTECODIGO",gxz:"ZV11cClienteCodigo",gxold:"OV11cClienteCodigo",gxvar:"AV11cClienteCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV11cClienteCodigo=a
},v2z:function(a){gx.O.ZV11cClienteCodigo=a},v2c:function(){gx.fn.setControlValue("vCCLIENTECODIGO",gx.O.AV11cClienteCodigo,0)},c2v:function(){gx.O.AV11cClienteCodigo=this.val()},val:function(){return gx.fn.getControlValue("vCCLIENTECODIGO")},nac:function(){return false}};this.GXValidFnc[42]={fld:"TEXTBLOCKFACTURADOCTO",format:0,grid:0};this.GXValidFnc[44]={lvl:0,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCFACTURADOCTO",gxz:"ZV12cFacturaDocto",gxold:"OV12cFacturaDocto",gxvar:"AV12cFacturaDocto",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV12cFacturaDocto=gx.num.intval(a)
},v2z:function(a){gx.O.ZV12cFacturaDocto=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCFACTURADOCTO",gx.O.AV12cFacturaDocto,0)},c2v:function(){gx.O.AV12cFacturaDocto=this.val()},val:function(){return gx.fn.getIntegerValue("vCFACTURADOCTO",",")},nac:function(){return false}};this.GXValidFnc[47]={fld:"GROUP2",grid:0};this.GXValidFnc[48]={fld:"TABLE3",grid:0};this.GXValidFnc[52]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV5LinkSelection=a
},v2z:function(a){gx.O.ZV5LinkSelection=a},v2c:function(){},c2v:function(){gx.O.AV5LinkSelection=this.val()},val:function(){return gx.fn.getGridControlValue("vLINKSELECTION",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[53]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CLINICACODIGO",gxz:"Z41ClinicaCodigo",gxold:"O41ClinicaCodigo",gxvar:"A41ClinicaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A41ClinicaCodigo=a
},v2z:function(a){gx.O.Z41ClinicaCodigo=a},v2c:function(){gx.fn.setGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(51),gx.O.A41ClinicaCodigo,0)},c2v:function(){gx.O.A41ClinicaCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("CLINICACODIGO",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[54]={lvl:2,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"FACTURAID",gxz:"Z185FacturaId",gxold:"O185FacturaId",gxvar:"A185FacturaId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A185FacturaId=gx.num.intval(a)
},v2z:function(a){gx.O.Z185FacturaId=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("FACTURAID",gx.fn.currentGridRowImpl(51),gx.O.A185FacturaId,0)},c2v:function(){gx.O.A185FacturaId=this.val()},val:function(){return gx.fn.getGridIntegerValue("FACTURAID",gx.fn.currentGridRowImpl(51),",")},nac:function(){return false}};this.GXValidFnc[55]={lvl:2,type:"date",len:8,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"FACTURAFECHA",gxz:"Z186FacturaFecha",gxold:"O186FacturaFecha",gxvar:"A186FacturaFecha",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A186FacturaFecha=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.Z186FacturaFecha=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setGridControlValue("FACTURAFECHA",gx.fn.currentGridRowImpl(51),gx.O.A186FacturaFecha,0)},c2v:function(){gx.O.A186FacturaFecha=this.val()},val:function(){return gx.fn.getGridControlValue("FACTURAFECHA",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[56]={lvl:2,type:"char",len:8,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"FACTURAHORA",gxz:"Z187FacturaHora",gxold:"O187FacturaHora",gxvar:"A187FacturaHora",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A187FacturaHora=a
},v2z:function(a){gx.O.Z187FacturaHora=a},v2c:function(){gx.fn.setGridControlValue("FACTURAHORA",gx.fn.currentGridRowImpl(51),gx.O.A187FacturaHora,0)},c2v:function(){gx.O.A187FacturaHora=this.val()},val:function(){return gx.fn.getGridControlValue("FACTURAHORA",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[57]={lvl:2,type:"int",len:1,dec:0,sign:false,pic:"9",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"FACTURAESTADO",gxz:"Z188FacturaEstado",gxold:"O188FacturaEstado",gxvar:"A188FacturaEstado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.A188FacturaEstado=gx.num.intval(a)
},v2z:function(a){gx.O.Z188FacturaEstado=gx.num.intval(a)},v2c:function(){gx.fn.setGridComboBoxValue("FACTURAESTADO",gx.fn.currentGridRowImpl(51),gx.O.A188FacturaEstado)},c2v:function(){gx.O.A188FacturaEstado=this.val()},val:function(){return gx.fn.getGridIntegerValue("FACTURAESTADO",gx.fn.currentGridRowImpl(51),",")},nac:function(){return false}};this.GXValidFnc[58]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CLIENTECODIGO",gxz:"Z178ClienteCodigo",gxold:"O178ClienteCodigo",gxvar:"A178ClienteCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A178ClienteCodigo=a
},v2z:function(a){gx.O.Z178ClienteCodigo=a},v2c:function(){gx.fn.setGridControlValue("CLIENTECODIGO",gx.fn.currentGridRowImpl(51),gx.O.A178ClienteCodigo,0)},c2v:function(){gx.O.A178ClienteCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("CLIENTECODIGO",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[59]={lvl:2,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"FACTURADOCTO",gxz:"Z189FacturaDocto",gxold:"O189FacturaDocto",gxvar:"A189FacturaDocto",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A189FacturaDocto=gx.num.intval(a)
},v2z:function(a){gx.O.Z189FacturaDocto=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("FACTURADOCTO",gx.fn.currentGridRowImpl(51),gx.O.A189FacturaDocto,0)},c2v:function(){gx.O.A189FacturaDocto=this.val()},val:function(){return gx.fn.getGridIntegerValue("FACTURADOCTO",gx.fn.currentGridRowImpl(51),",")},nac:function(){return false}};this.GXValidFnc[60]={lvl:2,type:"svchar",len:20,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"FACTURASERIE",gxz:"Z190FacturaSerie",gxold:"O190FacturaSerie",gxvar:"A190FacturaSerie",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A190FacturaSerie=a
},v2z:function(a){gx.O.Z190FacturaSerie=a},v2c:function(){gx.fn.setGridControlValue("FACTURASERIE",gx.fn.currentGridRowImpl(51),gx.O.A190FacturaSerie,0)},c2v:function(){gx.O.A190FacturaSerie=this.val()},val:function(){return gx.fn.getGridControlValue("FACTURASERIE",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[61]={lvl:2,type:"decimal",len:17,dec:2,sign:false,pic:"ZZZZZZZZZZZZZ9.99",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"FACTURAIVA",gxz:"Z191FacturaIva",gxold:"O191FacturaIva",gxvar:"A191FacturaIva",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A191FacturaIva=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.Z191FacturaIva=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setGridDecimalValue("FACTURAIVA",gx.fn.currentGridRowImpl(51),gx.O.A191FacturaIva,2,".")},c2v:function(){gx.O.A191FacturaIva=this.val()},val:function(){return gx.fn.getGridDecimalValue("FACTURAIVA",gx.fn.currentGridRowImpl(51),",",".")},nac:function(){return false}};this.GXValidFnc[62]={lvl:2,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"CONSULTAID",gxz:"Z91ConsultaId",gxold:"O91ConsultaId",gxvar:"A91ConsultaId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A91ConsultaId=gx.num.intval(a)
},v2z:function(a){gx.O.Z91ConsultaId=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("CONSULTAID",gx.fn.currentGridRowImpl(51),gx.O.A91ConsultaId,0)},c2v:function(){gx.O.A91ConsultaId=this.val()},val:function(){return gx.fn.getGridIntegerValue("CONSULTAID",gx.fn.currentGridRowImpl(51),",")},nac:function(){return false}};this.GXValidFnc[63]={lvl:2,type:"svchar",len:10,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CAJACODIGO",gxz:"Z132CajaCodigo",gxold:"O132CajaCodigo",gxvar:"A132CajaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A132CajaCodigo=a
},v2z:function(a){gx.O.Z132CajaCodigo=a},v2c:function(){gx.fn.setGridControlValue("CAJACODIGO",gx.fn.currentGridRowImpl(51),gx.O.A132CajaCodigo,0)},c2v:function(){gx.O.A132CajaCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("CAJACODIGO",gx.fn.currentGridRowImpl(51))},nac:function(){return false}};this.GXValidFnc[66]={fld:"TABLE4",grid:0};this.AV6cClinicaCodigo="";this.ZV6cClinicaCodigo="";this.OV6cClinicaCodigo="";this.AV7cFacturaId=0;this.ZV7cFacturaId=0;this.OV7cFacturaId=0;this.AV8cFacturaFecha=gx.date.nullDate();
this.ZV8cFacturaFecha=gx.date.nullDate();this.OV8cFacturaFecha=gx.date.nullDate();this.AV9cFacturaHora="";this.ZV9cFacturaHora="";this.OV9cFacturaHora="";this.AV10cFacturaEstado=0;this.ZV10cFacturaEstado=0;this.OV10cFacturaEstado=0;this.AV11cClienteCodigo="";this.ZV11cClienteCodigo="";this.OV11cClienteCodigo="";this.AV12cFacturaDocto=0;this.ZV12cFacturaDocto=0;this.OV12cFacturaDocto=0;this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z41ClinicaCodigo="";this.O41ClinicaCodigo="";this.Z185FacturaId=0;
this.O185FacturaId=0;this.Z186FacturaFecha=gx.date.nullDate();this.O186FacturaFecha=gx.date.nullDate();this.Z187FacturaHora="";this.O187FacturaHora="";this.Z188FacturaEstado=0;this.O188FacturaEstado=0;this.Z178ClienteCodigo="";this.O178ClienteCodigo="";this.Z189FacturaDocto=0;this.O189FacturaDocto=0;this.Z190FacturaSerie="";this.O190FacturaSerie="";this.Z191FacturaIva=0;this.O191FacturaIva=0;this.Z91ConsultaId=0;this.O91ConsultaId=0;this.Z132CajaCodigo="";this.O132CajaCodigo="";this.AV13pClinicaCodigo="";
this.AV14pFacturaId=0;this.AV5LinkSelection="";this.A41ClinicaCodigo="";this.A185FacturaId=0;this.A186FacturaFecha=gx.date.nullDate();this.A187FacturaHora="";this.A188FacturaEstado=0;this.A178ClienteCodigo="";this.A189FacturaDocto=0;this.A190FacturaSerie="";this.A191FacturaIva=0;this.A91ConsultaId=0;this.A132CajaCodigo="";this.ServerEvents=["e131u2_client","e141u1_client"];this.VarControlMap.AV13pClinicaCodigo={id:"vPCLINICACODIGO",grid:0,type:"svchar"};this.VarControlMap.AV14pFacturaId={id:"vPFACTURAID",grid:0,type:"int"};
this.Grid1Container.addRefreshingVar(this.GXValidFnc[14]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[19]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[24]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[29]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[34]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[39]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[44]);this.SetStandaloneVars()}gx01d0.prototype=new gx.GxObject;gx.setParentObj(new gx01d0());