gx.evt.autoSkip=false;function factura(){this.ServerClass="Factura";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=true;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Clinicacodigo=function(){try{var a=gx.util.balloon.getNew("CLINICACODIGO");this.AnyError=0}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Facturaid=function(){gx.ajax.validSrvEvt("dyncall","Valid_Facturaid",["gx.O.A41ClinicaCodigo","gx.O.A185FacturaId",'gx.date.urlDate(gx.O.A186FacturaFecha,"DMY")',"gx.O.A187FacturaHora","gx.O.A188FacturaEstado","gx.O.A189FacturaDocto","gx.O.A190FacturaSerie","gx.num.urlDecimal(gx.O.A191FacturaIva,',','.')","gx.O.A192FacturaCae1","gx.O.A229FacturaCae2",'gx.date.urlDateTime(gx.O.A280FacturaFechaHora,"DMY")',"gx.O.A281CorteCajaIdF","gx.O.A91ConsultaId","gx.O.A132CajaCodigo","gx.O.A178ClienteCodigo","gx.O.A4UsuarioCodigo","gx.num.urlDecimal(gx.O.A247FacturaTotal,',','.')","gx.num.urlDecimal(gx.O.A263FacturaPago,',','.')"],["A186FacturaFecha","A187FacturaHora","A188FacturaEstado","A178ClienteCodigo","A189FacturaDocto","A190FacturaSerie","A191FacturaIva","A192FacturaCae1","A229FacturaCae2","A91ConsultaId","A132CajaCodigo","A4UsuarioCodigo","A280FacturaFechaHora","A281CorteCajaIdF","A247FacturaTotal","A263FacturaPago","Gx_mode","Z41ClinicaCodigo","Z185FacturaId","Z186FacturaFecha","Z187FacturaHora","Z188FacturaEstado","Z178ClienteCodigo","Z189FacturaDocto","Z190FacturaSerie","Z191FacturaIva","Z192FacturaCae1","Z229FacturaCae2","Z91ConsultaId","Z132CajaCodigo","Z4UsuarioCodigo","Z280FacturaFechaHora","Z281CorteCajaIdF","Z247FacturaTotal","Z263FacturaPago","O247FacturaTotal","Gridfactura_facturadetalle",["BTN_DELETE2","Enabled"],["BTN_ENTER2","Enabled"]]);
return true};this.Valid_Facturafecha=function(){try{var a=gx.util.balloon.getNew("FACTURAFECHA");this.AnyError=0;if(!((new gx.date.gxdate("").compare(this.A186FacturaFecha)==0)||new gx.date.gxdate(this.A186FacturaFecha).compare(gx.date.ymdtod(1753,1,1))>=0)){try{a.setError("Campo Fecha fuera de rango");this.AnyError=1}catch(b){}}}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Clientecodigo=function(){gx.ajax.validSrvEvt("dyncall","Valid_Clientecodigo",["gx.O.A41ClinicaCodigo","gx.O.A178ClienteCodigo"],[]);
return true};this.Valid_Consultaid=function(){gx.ajax.validSrvEvt("dyncall","Valid_Consultaid",["gx.O.A41ClinicaCodigo","gx.O.A91ConsultaId"],[]);return true};this.Valid_Cajacodigo=function(){gx.ajax.validSrvEvt("dyncall","Valid_Cajacodigo",["gx.O.A41ClinicaCodigo","gx.O.A132CajaCodigo"],[]);return true};this.Valid_Usuariocodigo=function(){gx.ajax.validSrvEvt("dyncall","Valid_Usuariocodigo",["gx.O.A4UsuarioCodigo"],[]);return true};this.Valid_Facturafechahora=function(){try{var a=gx.util.balloon.getNew("FACTURAFECHAHORA");
this.AnyError=0;if(!((new gx.date.gxdate("").compare(this.A280FacturaFechaHora)==0)||new gx.date.gxdate(this.A280FacturaFechaHora).compare(gx.date.ymdhmstot(1753,1,1,0,0,0))>=0)){try{a.setError("Campo FechaHora fuera de rango");this.AnyError=1}catch(b){}}}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Facturadid=function(){try{if(gx.fn.currentGridRowImpl(130)===0){return true}var a=gx.util.balloon.getNew("FACTURADID",gx.fn.currentGridRowImpl(130));this.AnyError=0;
this.sMode60=this.Gx_mode;this.Gx_mode=gx.fn.getGridRowMode(60,130);this.standaloneModal1260();this.standaloneNotModal1260();if(gx.fn.gridDuplicateKey(131)){a.setError(gx.text.format(gx.getMessage("GXM_1004"),"Detalle de Factura a Pacientes","","","","","","","",""));this.AnyError=1}}catch(b){}try{this.Gx_mode=this.sMode60;if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Articulocodigo=function(){this.sMode60=this.Gx_mode;this.Gx_mode=gx.fn.getGridRowMode(60,130);gx.ajax.validSrvEvt("dyncall","Valid_Articulocodigo",["gx.O.A41ClinicaCodigo","gx.O.A30ArticuloCodigo"],[]);
this.Gx_mode=this.sMode60;return true};this.Valid_Facturadprecio=function(){try{if(gx.fn.currentGridRowImpl(130)===0){return true}var a=gx.util.balloon.getNew("FACTURADPRECIO",gx.fn.currentGridRowImpl(130));this.AnyError=0;this.sMode60=this.Gx_mode;this.Gx_mode=gx.fn.getGridRowMode(60,130)}catch(b){}try{this.Gx_mode=this.sMode60;if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Facturadcantidad=function(){try{if(gx.fn.currentGridRowImpl(130)===0){return true}var a=gx.util.balloon.getNew("FACTURADCANTIDAD",gx.fn.currentGridRowImpl(130));
this.AnyError=0;this.sMode60=this.Gx_mode;this.Gx_mode=gx.fn.getGridRowMode(60,130);try{this.A251FacturaDTotal=gx.num.multiply(this.A249FacturaDPrecio,this.A250FacturaDCantidad)}catch(b){}try{this.A247FacturaTotal=gx.fn.sumFrm("A251FacturaDTotal",0,",",".",130,function(){return true},[])}catch(b){}}catch(b){}try{this.Gx_mode=this.sMode60;if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Facturadtotal=function(){try{if(gx.fn.currentGridRowImpl(130)===0){return true}var a=gx.util.balloon.getNew("FACTURADTOTAL",gx.fn.currentGridRowImpl(130));
this.AnyError=0;this.sMode60=this.Gx_mode;this.Gx_mode=gx.fn.getGridRowMode(60,130);if(this.Gx_mode=="UPD"){}}catch(b){}try{this.Gx_mode=this.sMode60;if(a==null){return true}return a.show()}catch(b){}return true};this.standaloneModal1260=function(){try{if(this.Gx_mode!="INS"){gx.fn.setCtrlProperty("FACTURADID","Enabled",0)}else{gx.fn.setCtrlProperty("FACTURADID","Enabled",1)}}catch(a){}return true};this.standaloneNotModal1260=function(){return true};this.e111249_client=function(){this.executeServerEvent("ENTER",true)
};this.e121249_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[2,5,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,26,27,33,36,38,41,43,46,48,51,53,56,58,61,63,66,68,71,73,76,78,81,83,86,88,91,93,96,98,101,103,106,108,111,113,116,118,121,123,126,129,131,132,133,134,135,141,142,143,144];this.GXLastCtrlId=144;this.Gridfactura_facturadetalleContainer=new gx.grid.grid(this,60,"FacturaDetalle",130,"Gridfactura_facturadetalle","Gridfactura_facturadetalle","Gridfactura_facturadetalleContainer",this.CmpContext,this.IsMasterPage,"factura",[248],false,1,false,true,5,false,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");
this.Gridfactura_facturadetalleContainer.addSingleLineEdit(248,131,"FACTURADID","Línea","","FacturaDId","int",0,"px",9,9,"right",null,[],248,"FacturaDId",true,0,false,false);this.Gridfactura_facturadetalleContainer.addSingleLineEdit(30,132,"ARTICULOCODIGO","Artículo","","ArticuloCodigo","svchar",0,"px",10,10,"left",null,[],30,"ArticuloCodigo",true,0,false,false);this.Gridfactura_facturadetalleContainer.addBitmap("prompt_30","PROMPT_30",145,0,"",0,"",null,"","");this.Gridfactura_facturadetalleContainer.addSingleLineEdit(249,133,"FACTURADPRECIO","Precio","","FacturaDPrecio","decimal",0,"px",17,17,"right",null,[],249,"FacturaDPrecio",true,2,false,false);
this.Gridfactura_facturadetalleContainer.addSingleLineEdit(250,134,"FACTURADCANTIDAD","Cantidad","","FacturaDCantidad","decimal",0,"px",17,17,"right",null,[],250,"FacturaDCantidad",true,2,false,false);this.Gridfactura_facturadetalleContainer.addSingleLineEdit(251,135,"FACTURADTOTAL","Linea","","FacturaDTotal","decimal",0,"px",17,17,"right",null,[],251,"FacturaDTotal",true,2,false,false);this.setGrid(this.Gridfactura_facturadetalleContainer);this.GXValidFnc[2]={fld:"TABLEMAIN",grid:0};this.GXValidFnc[5]={fld:"TABLETOOLBAR",grid:0};
this.GXValidFnc[8]={fld:"BTN_FIRST",grid:0};this.GXValidFnc[9]={fld:"BTN_FIRST_SEPARATOR",grid:0};this.GXValidFnc[10]={fld:"BTN_PREVIOUS",grid:0};this.GXValidFnc[11]={fld:"BTN_PREVIOUS_SEPARATOR",grid:0};this.GXValidFnc[12]={fld:"BTN_NEXT",grid:0};this.GXValidFnc[13]={fld:"BTN_NEXT_SEPARATOR",grid:0};this.GXValidFnc[14]={fld:"BTN_LAST",grid:0};this.GXValidFnc[15]={fld:"BTN_LAST_SEPARATOR",grid:0};this.GXValidFnc[16]={fld:"BTN_SELECT",grid:0};this.GXValidFnc[17]={fld:"BTN_SELECT_SEPARATOR",grid:0};
this.GXValidFnc[18]={fld:"BTN_ENTER2",grid:0};this.GXValidFnc[19]={fld:"BTN_ENTER2_SEPARATOR",grid:0};this.GXValidFnc[20]={fld:"BTN_CANCEL2",grid:0};this.GXValidFnc[21]={fld:"BTN_CANCEL2_SEPARATOR",grid:0};this.GXValidFnc[22]={fld:"BTN_DELETE2",grid:0};this.GXValidFnc[23]={fld:"BTN_DELETE2_SEPARATOR",grid:0};this.GXValidFnc[26]={fld:"GROUPDATA",grid:0};this.GXValidFnc[27]={fld:"TABLE1",grid:0};this.GXValidFnc[33]={fld:"TABLE2",grid:0};this.GXValidFnc[36]={fld:"TEXTBLOCKCLINICACODIGO",format:0,grid:0};
this.GXValidFnc[38]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Clinicacodigo,isvalid:null,fld:"CLINICACODIGO",gxz:"Z41ClinicaCodigo",gxold:"O41ClinicaCodigo",gxvar:"A41ClinicaCodigo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A41ClinicaCodigo=a},v2z:function(a){gx.O.Z41ClinicaCodigo=a},v2c:function(){gx.fn.setControlValue("CLINICACODIGO",gx.O.A41ClinicaCodigo,0)},c2v:function(){gx.O.A41ClinicaCodigo=this.val()},val:function(){return gx.fn.getControlValue("CLINICACODIGO")
},nac:function(){return false}};this.GXValidFnc[41]={fld:"TEXTBLOCKFACTURAID",format:0,grid:0};this.GXValidFnc[43]={lvl:0,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Facturaid,isvalid:null,rgrid:[this.Gridfactura_facturadetalleContainer],fld:"FACTURAID",gxz:"Z185FacturaId",gxold:"O185FacturaId",gxvar:"A185FacturaId",ucs:[],op:[88,83,113,63,108,103,123,118,98,93,78,73,68,58,53,48],ip:[88,83,113,63,108,103,123,118,98,93,78,73,68,58,53,48,43,38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A185FacturaId=gx.num.intval(a)
},v2z:function(a){gx.O.Z185FacturaId=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("FACTURAID",gx.O.A185FacturaId,0)},c2v:function(){gx.O.A185FacturaId=this.val()},val:function(){return gx.fn.getIntegerValue("FACTURAID",",")},nac:function(){return false}};this.GXValidFnc[46]={fld:"TEXTBLOCKFACTURAFECHA",format:0,grid:0};this.GXValidFnc[48]={lvl:0,type:"date",len:8,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Facturafecha,isvalid:null,fld:"FACTURAFECHA",gxz:"Z186FacturaFecha",gxold:"O186FacturaFecha",gxvar:"A186FacturaFecha",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/99",dec:0},ucs:[],op:[48],ip:[48],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A186FacturaFecha=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.Z186FacturaFecha=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setControlValue("FACTURAFECHA",gx.O.A186FacturaFecha,0)},c2v:function(){gx.O.A186FacturaFecha=this.val()},val:function(){return gx.fn.getControlValue("FACTURAFECHA")},nac:function(){return false}};this.GXValidFnc[51]={fld:"TEXTBLOCKFACTURAHORA",format:0,grid:0};this.GXValidFnc[53]={lvl:0,type:"char",len:8,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"FACTURAHORA",gxz:"Z187FacturaHora",gxold:"O187FacturaHora",gxvar:"A187FacturaHora",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A187FacturaHora=a
},v2z:function(a){gx.O.Z187FacturaHora=a},v2c:function(){gx.fn.setControlValue("FACTURAHORA",gx.O.A187FacturaHora,0)},c2v:function(){gx.O.A187FacturaHora=this.val()},val:function(){return gx.fn.getControlValue("FACTURAHORA")},nac:function(){return false}};this.GXValidFnc[56]={fld:"TEXTBLOCKFACTURAESTADO",format:0,grid:0};this.GXValidFnc[58]={lvl:0,type:"int",len:1,dec:0,sign:false,pic:"9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"FACTURAESTADO",gxz:"Z188FacturaEstado",gxold:"O188FacturaEstado",gxvar:"A188FacturaEstado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(a){gx.O.A188FacturaEstado=gx.num.intval(a)
},v2z:function(a){gx.O.Z188FacturaEstado=gx.num.intval(a)},v2c:function(){gx.fn.setComboBoxValue("FACTURAESTADO",gx.O.A188FacturaEstado)},c2v:function(){gx.O.A188FacturaEstado=this.val()},val:function(){return gx.fn.getIntegerValue("FACTURAESTADO",",")},nac:function(){return false}};this.GXValidFnc[61]={fld:"TEXTBLOCKCLIENTECODIGO",format:0,grid:0};this.GXValidFnc[63]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Clientecodigo,isvalid:null,fld:"CLIENTECODIGO",gxz:"Z178ClienteCodigo",gxold:"O178ClienteCodigo",gxvar:"A178ClienteCodigo",ucs:[],op:[],ip:[63,38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A178ClienteCodigo=a
},v2z:function(a){gx.O.Z178ClienteCodigo=a},v2c:function(){gx.fn.setControlValue("CLIENTECODIGO",gx.O.A178ClienteCodigo,0)},c2v:function(){gx.O.A178ClienteCodigo=this.val()},val:function(){return gx.fn.getControlValue("CLIENTECODIGO")},nac:function(){return false}};this.GXValidFnc[66]={fld:"TEXTBLOCKFACTURADOCTO",format:0,grid:0};this.GXValidFnc[68]={lvl:0,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"FACTURADOCTO",gxz:"Z189FacturaDocto",gxold:"O189FacturaDocto",gxvar:"A189FacturaDocto",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A189FacturaDocto=gx.num.intval(a)
},v2z:function(a){gx.O.Z189FacturaDocto=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("FACTURADOCTO",gx.O.A189FacturaDocto,0)},c2v:function(){gx.O.A189FacturaDocto=this.val()},val:function(){return gx.fn.getIntegerValue("FACTURADOCTO",",")},nac:function(){return false}};this.GXValidFnc[71]={fld:"TEXTBLOCKFACTURASERIE",format:0,grid:0};this.GXValidFnc[73]={lvl:0,type:"svchar",len:20,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"FACTURASERIE",gxz:"Z190FacturaSerie",gxold:"O190FacturaSerie",gxvar:"A190FacturaSerie",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A190FacturaSerie=a
},v2z:function(a){gx.O.Z190FacturaSerie=a},v2c:function(){gx.fn.setControlValue("FACTURASERIE",gx.O.A190FacturaSerie,0)},c2v:function(){gx.O.A190FacturaSerie=this.val()},val:function(){return gx.fn.getControlValue("FACTURASERIE")},nac:function(){return false}};this.GXValidFnc[76]={fld:"TEXTBLOCKFACTURAIVA",format:0,grid:0};this.GXValidFnc[78]={lvl:0,type:"decimal",len:17,dec:2,sign:false,pic:"ZZZZZZZZZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"FACTURAIVA",gxz:"Z191FacturaIva",gxold:"O191FacturaIva",gxvar:"A191FacturaIva",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A191FacturaIva=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.Z191FacturaIva=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setDecimalValue("FACTURAIVA",gx.O.A191FacturaIva,2,".")},c2v:function(){gx.O.A191FacturaIva=this.val()},val:function(){return gx.fn.getDecimalValue("FACTURAIVA",",",".")},nac:function(){return false}};this.GXValidFnc[81]={fld:"TEXTBLOCKFACTURATOTAL",format:0,grid:0};this.GXValidFnc[83]={lvl:0,type:"decimal",len:17,dec:2,sign:false,pic:"ZZZZZZZZZZZZZ9.99",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"FACTURATOTAL",gxz:"Z247FacturaTotal",gxold:"O247FacturaTotal",gxvar:"A247FacturaTotal",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A247FacturaTotal=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.Z247FacturaTotal=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setDecimalValue("FACTURATOTAL",gx.O.A247FacturaTotal,2,".")},c2v:function(){gx.O.A247FacturaTotal=this.val()},val:function(){return gx.fn.getDecimalValue("FACTURATOTAL",",",".")},nac:function(){return false}};this.GXValidFnc[86]={fld:"TEXTBLOCKFACTURAPAGO",format:0,grid:0};this.GXValidFnc[88]={lvl:0,type:"decimal",len:17,dec:2,sign:false,pic:"ZZZZZZZZZZZZZ9.99",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"FACTURAPAGO",gxz:"Z263FacturaPago",gxold:"O263FacturaPago",gxvar:"A263FacturaPago",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A263FacturaPago=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.Z263FacturaPago=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setDecimalValue("FACTURAPAGO",gx.O.A263FacturaPago,2,".")},c2v:function(){gx.O.A263FacturaPago=this.val()},val:function(){return gx.fn.getDecimalValue("FACTURAPAGO",",",".")},nac:function(){return false}};this.GXValidFnc[91]={fld:"TEXTBLOCKFACTURACAE1",format:0,grid:0};this.GXValidFnc[93]={lvl:0,type:"svchar",len:1000,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"FACTURACAE1",gxz:"Z192FacturaCae1",gxold:"O192FacturaCae1",gxvar:"A192FacturaCae1",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A192FacturaCae1=a
},v2z:function(a){gx.O.Z192FacturaCae1=a},v2c:function(){gx.fn.setControlValue("FACTURACAE1",gx.O.A192FacturaCae1,0)},c2v:function(){gx.O.A192FacturaCae1=this.val()},val:function(){return gx.fn.getControlValue("FACTURACAE1")},nac:function(){return false}};this.GXValidFnc[96]={fld:"TEXTBLOCKFACTURACAE2",format:0,grid:0};this.GXValidFnc[98]={lvl:0,type:"svchar",len:1000,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"FACTURACAE2",gxz:"Z229FacturaCae2",gxold:"O229FacturaCae2",gxvar:"A229FacturaCae2",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A229FacturaCae2=a
},v2z:function(a){gx.O.Z229FacturaCae2=a},v2c:function(){gx.fn.setControlValue("FACTURACAE2",gx.O.A229FacturaCae2,0)},c2v:function(){gx.O.A229FacturaCae2=this.val()},val:function(){return gx.fn.getControlValue("FACTURACAE2")},nac:function(){return false}};this.GXValidFnc[101]={fld:"TEXTBLOCKCONSULTAID",format:0,grid:0};this.GXValidFnc[103]={lvl:0,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Consultaid,isvalid:null,rgrid:[],fld:"CONSULTAID",gxz:"Z91ConsultaId",gxold:"O91ConsultaId",gxvar:"A91ConsultaId",ucs:[],op:[],ip:[103,38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A91ConsultaId=gx.num.intval(a)
},v2z:function(a){gx.O.Z91ConsultaId=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("CONSULTAID",gx.O.A91ConsultaId,0)},c2v:function(){gx.O.A91ConsultaId=this.val()},val:function(){return gx.fn.getIntegerValue("CONSULTAID",",")},nac:function(){return false}};this.GXValidFnc[106]={fld:"TEXTBLOCKCAJACODIGO",format:0,grid:0};this.GXValidFnc[108]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Cajacodigo,isvalid:null,fld:"CAJACODIGO",gxz:"Z132CajaCodigo",gxold:"O132CajaCodigo",gxvar:"A132CajaCodigo",ucs:[],op:[],ip:[108,38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A132CajaCodigo=a
},v2z:function(a){gx.O.Z132CajaCodigo=a},v2c:function(){gx.fn.setControlValue("CAJACODIGO",gx.O.A132CajaCodigo,0)},c2v:function(){gx.O.A132CajaCodigo=this.val()},val:function(){return gx.fn.getControlValue("CAJACODIGO")},nac:function(){return false}};this.GXValidFnc[111]={fld:"TEXTBLOCKUSUARIOCODIGO",format:0,grid:0};this.GXValidFnc[113]={lvl:0,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Usuariocodigo,isvalid:null,fld:"USUARIOCODIGO",gxz:"Z4UsuarioCodigo",gxold:"O4UsuarioCodigo",gxvar:"A4UsuarioCodigo",ucs:[],op:[],ip:[113],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A4UsuarioCodigo=a
},v2z:function(a){gx.O.Z4UsuarioCodigo=a},v2c:function(){gx.fn.setControlValue("USUARIOCODIGO",gx.O.A4UsuarioCodigo,0)},c2v:function(){gx.O.A4UsuarioCodigo=this.val()},val:function(){return gx.fn.getControlValue("USUARIOCODIGO")},nac:function(){return false}};this.GXValidFnc[116]={fld:"TEXTBLOCKFACTURAFECHAHORA",format:0,grid:0};this.GXValidFnc[118]={lvl:0,type:"dtime",len:8,dec:5,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Facturafechahora,isvalid:null,fld:"FACTURAFECHAHORA",gxz:"Z280FacturaFechaHora",gxold:"O280FacturaFechaHora",gxvar:"A280FacturaFechaHora",dp:{f:0,st:true,wn:false,mf:false,pic:"99/99/99 99:99",dec:5},ucs:[],op:[118],ip:[118],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A280FacturaFechaHora=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.Z280FacturaFechaHora=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setControlValue("FACTURAFECHAHORA",gx.O.A280FacturaFechaHora,0)},c2v:function(){gx.O.A280FacturaFechaHora=this.val()},val:function(){return gx.fn.getControlValue("FACTURAFECHAHORA")},nac:function(){return false}};this.GXValidFnc[121]={fld:"TEXTBLOCKCORTECAJAIDF",format:0,grid:0};this.GXValidFnc[123]={lvl:0,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"CORTECAJAIDF",gxz:"Z281CorteCajaIdF",gxold:"O281CorteCajaIdF",gxvar:"A281CorteCajaIdF",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A281CorteCajaIdF=gx.num.intval(a)
},v2z:function(a){gx.O.Z281CorteCajaIdF=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("CORTECAJAIDF",gx.O.A281CorteCajaIdF,0)},c2v:function(){gx.O.A281CorteCajaIdF=this.val()},val:function(){return gx.fn.getIntegerValue("CORTECAJAIDF",",")},nac:function(){return false}};this.GXValidFnc[126]={fld:"TABLE3",grid:0};this.GXValidFnc[129]={fld:"TITLEFACTURADETALLE",format:0,grid:0};this.GXValidFnc[131]={lvl:60,type:"int",len:9,dec:0,sign:false,pic:"ZZZZZZZZ9",ro:0,grid:130,gxgrid:this.Gridfactura_facturadetalleContainer,fnc:this.Valid_Facturadid,isvalid:null,rgrid:[],fld:"FACTURADID",gxz:"Z248FacturaDId",gxold:"O248FacturaDId",gxvar:"A248FacturaDId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A248FacturaDId=gx.num.intval(a)
},v2z:function(a){gx.O.Z248FacturaDId=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("FACTURADID",gx.fn.currentGridRowImpl(130),gx.O.A248FacturaDId,0)},c2v:function(){gx.O.A248FacturaDId=this.val()},val:function(){return gx.fn.getGridIntegerValue("FACTURADID",gx.fn.currentGridRowImpl(130),",")},nac:function(){return false}};this.GXValidFnc[132]={lvl:60,type:"svchar",len:10,dec:0,sign:false,ro:0,grid:130,gxgrid:this.Gridfactura_facturadetalleContainer,fnc:this.Valid_Articulocodigo,isvalid:null,fld:"ARTICULOCODIGO",gxz:"Z30ArticuloCodigo",gxold:"O30ArticuloCodigo",gxvar:"A30ArticuloCodigo",ucs:[],op:[],ip:[132,38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A30ArticuloCodigo=a
},v2z:function(a){gx.O.Z30ArticuloCodigo=a},v2c:function(){gx.fn.setGridControlValue("ARTICULOCODIGO",gx.fn.currentGridRowImpl(130),gx.O.A30ArticuloCodigo,0)},c2v:function(){gx.O.A30ArticuloCodigo=this.val()},val:function(){return gx.fn.getGridControlValue("ARTICULOCODIGO",gx.fn.currentGridRowImpl(130))},nac:function(){return false}};this.GXValidFnc[133]={lvl:60,type:"decimal",len:17,dec:2,sign:false,pic:"ZZZZZZZZZZZZZ9.99",ro:0,grid:130,gxgrid:this.Gridfactura_facturadetalleContainer,fnc:this.Valid_Facturadprecio,isvalid:null,rgrid:[],fld:"FACTURADPRECIO",gxz:"Z249FacturaDPrecio",gxold:"O249FacturaDPrecio",gxvar:"A249FacturaDPrecio",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A249FacturaDPrecio=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.Z249FacturaDPrecio=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setGridDecimalValue("FACTURADPRECIO",gx.fn.currentGridRowImpl(130),gx.O.A249FacturaDPrecio,2,".")},c2v:function(){gx.O.A249FacturaDPrecio=this.val()},val:function(){return gx.fn.getGridDecimalValue("FACTURADPRECIO",gx.fn.currentGridRowImpl(130),",",".")},nac:function(){return false}};this.GXValidFnc[134]={lvl:60,type:"decimal",len:17,dec:2,sign:false,pic:"ZZZZZZZZZZZZZ9.99",ro:0,grid:130,gxgrid:this.Gridfactura_facturadetalleContainer,fnc:this.Valid_Facturadcantidad,isvalid:null,rgrid:[],fld:"FACTURADCANTIDAD",gxz:"Z250FacturaDCantidad",gxold:"O250FacturaDCantidad",gxvar:"A250FacturaDCantidad",ucs:[],op:[135,83],ip:[83,135,134,133],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A250FacturaDCantidad=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.Z250FacturaDCantidad=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setGridDecimalValue("FACTURADCANTIDAD",gx.fn.currentGridRowImpl(130),gx.O.A250FacturaDCantidad,2,".")},c2v:function(){gx.O.A250FacturaDCantidad=this.val()},val:function(){return gx.fn.getGridDecimalValue("FACTURADCANTIDAD",gx.fn.currentGridRowImpl(130),",",".")},nac:function(){return false}};this.GXValidFnc[135]={lvl:60,type:"decimal",len:17,dec:2,sign:false,pic:"ZZZZZZZZZZZZZ9.99",ro:1,grid:130,gxgrid:this.Gridfactura_facturadetalleContainer,fnc:this.Valid_Facturadtotal,isvalid:null,rgrid:[],fld:"FACTURADTOTAL",gxz:"Z251FacturaDTotal",gxold:"O251FacturaDTotal",gxvar:"A251FacturaDTotal",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A251FacturaDTotal=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.Z251FacturaDTotal=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setGridDecimalValue("FACTURADTOTAL",gx.fn.currentGridRowImpl(130),gx.O.A251FacturaDTotal,2,".")},c2v:function(){gx.O.A251FacturaDTotal=this.val()},val:function(){return gx.fn.getGridDecimalValue("FACTURADTOTAL",gx.fn.currentGridRowImpl(130),",",".")},nac:function(){return false}};this.GXValidFnc[141]={fld:"PROMPT_41_178",grid:49};this.GXValidFnc[142]={fld:"PROMPT_41_91",grid:49};this.GXValidFnc[143]={fld:"PROMPT_41_132",grid:49};
this.GXValidFnc[144]={fld:"PROMPT_4",grid:49};this.A41ClinicaCodigo="";this.Z41ClinicaCodigo="";this.O41ClinicaCodigo="";this.A185FacturaId=0;this.Z185FacturaId=0;this.O185FacturaId=0;this.A186FacturaFecha=gx.date.nullDate();this.Z186FacturaFecha=gx.date.nullDate();this.O186FacturaFecha=gx.date.nullDate();this.A187FacturaHora="";this.Z187FacturaHora="";this.O187FacturaHora="";this.A188FacturaEstado=0;this.Z188FacturaEstado=0;this.O188FacturaEstado=0;this.A178ClienteCodigo="";this.Z178ClienteCodigo="";
this.O178ClienteCodigo="";this.A189FacturaDocto=0;this.Z189FacturaDocto=0;this.O189FacturaDocto=0;this.A190FacturaSerie="";this.Z190FacturaSerie="";this.O190FacturaSerie="";this.A191FacturaIva=0;this.Z191FacturaIva=0;this.O191FacturaIva=0;this.A247FacturaTotal=0;this.Z247FacturaTotal=0;this.O247FacturaTotal=0;this.A263FacturaPago=0;this.Z263FacturaPago=0;this.O263FacturaPago=0;this.A192FacturaCae1="";this.Z192FacturaCae1="";this.O192FacturaCae1="";this.A229FacturaCae2="";this.Z229FacturaCae2="";this.O229FacturaCae2="";
this.A91ConsultaId=0;this.Z91ConsultaId=0;this.O91ConsultaId=0;this.A132CajaCodigo="";this.Z132CajaCodigo="";this.O132CajaCodigo="";this.A4UsuarioCodigo="";this.Z4UsuarioCodigo="";this.O4UsuarioCodigo="";this.A280FacturaFechaHora=gx.date.nullDate();this.Z280FacturaFechaHora=gx.date.nullDate();this.O280FacturaFechaHora=gx.date.nullDate();this.A281CorteCajaIdF=0;this.Z281CorteCajaIdF=0;this.O281CorteCajaIdF=0;this.Z248FacturaDId=0;this.O248FacturaDId=0;this.Z30ArticuloCodigo="";this.O30ArticuloCodigo="";
this.Z249FacturaDPrecio=0;this.O249FacturaDPrecio=0;this.Z250FacturaDCantidad=0;this.O250FacturaDCantidad=0;this.Z251FacturaDTotal=0;this.O251FacturaDTotal=0;this.A248FacturaDId=0;this.A251FacturaDTotal=0;this.A30ArticuloCodigo="";this.A249FacturaDPrecio=0;this.A250FacturaDCantidad=0;this.ServerEvents=["e111249_client","e121249_client"];this.setPrompt("PROMPT_41_178",[38,63]);this.setPrompt("PROMPT_41_91",[38,103]);this.setPrompt("PROMPT_41_132",[38,108]);this.setPrompt("PROMPT_4",[113]);this.setPrompt("PROMPT_30",[132]);
this.EnterCtrl=["BTN_ENTER2","BTN_ENTER2_SEPARATOR","BTN_ENTER"];this.VarControlMap.Gx_mode={id:"vMODE",grid:0,type:"char"};this.SetStandaloneVars();this.LvlOlds[49]=["O247FacturaTotal"];this.LvlOlds[60]=["O251FacturaDTotal"]}factura.prototype=new gx.GxObject;gx.setParentObj(new factura());