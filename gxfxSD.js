gx.fx={delayedSuggest:function(){var a=gx.suggestControls.length;for(var b=0;b<a;b++){this.installSuggest(gx.suggestControls[b])}},installSuggest:function(a){if(document.readyState!=undefined&&document.readyState!="complete"){gx.suggestControls.push(a);return}try{var f=gx.O.getValidStructFld(a.id);if(f&&!gx.lang.emptyObject(f.gxsgprm)){var d=(f.grid>0)?gx.fn.currentGridRowImpl(f.grid):"main";var b=f.gxsgprm;if(!b.installed){b.installed={}}if(!b.installed[d]){gx.ajax.suggest(b[1],a.id,b[0],b[3],b[2]);b.installed[d]=true}}}catch(c){gx.dbg.logEx(c,"gxfx.js","installSuggest")}},updateSuggestParms:function(c){if(c!=undefined){var a=c.length;for(var b=0;b<a;b++){var d=gx.fn.validStruct(c[b]);if(d!=undefined&&d!=null&&typeof(d.c2v)=="function"){d.c2v()}}}},firesuggest:function(b,d,c,a){this.updateSuggestParms(a);if(b.textbox.value!=""){d.requestSuggestions(b,c)}},autoSuggestControl:function(b,a,d,e,c,f){this.cur=-1;this.IFrameControl=null;this.layer=null;this.provider=a;this.textbox=b;if(typeof(this.textbox.GXonblur)=="undefined"){this.textbox.GXonblur=b.onblur}this.ControlRefresh=d;this.typeahead=e;this.suggestParms=c||[];this.sdtParms=f||[];this.requestSuggestions=function(h,j,i){var g=this.suggestParms;if(this.timer!=undefined){window.clearTimeout(this.timer)}this.timer=window.setTimeout(function(){gx.fx.firesuggest(h,j,i,g)},400)};this.hideSuggestions=function(){if(this.IFrameControl){this.IFrameControl.style.visibility="hidden"}this.layer.style.visibility="hidden"};this.highlightSuggestion=function(h){var g=this.layer.childNodes.length;for(var j=0;j<g;j++){var k=this.layer.childNodes[j];if(k==h){k.className="current"}else{if(k.className=="current"){k.className=""}}}};this.init=function(){var g=this;this.textbox.onkeyup=function(h){if(!h){h=window.event}g.handleKeyUp(h)};this.textbox.onkeydown=function(h){if(!h){h=window.event}g.handleKeyDown(h)};this.textbox.onblur=function(){g.hideSuggestions();g.textbox.GXonblur()};this.createDropDown()};this.nextSuggestion=function(){var h=this.layer.childNodes;if(h.length>0){this.cur=(this.cur<h.length-1)?this.cur+1:0;var g=h[this.cur];this.highlightSuggestion(g);this.pickvalue(g.firstChild.nodeValue)}};this.previousSuggestion=function(){var h=this.layer.childNodes;if(h.length>0){this.cur=(this.cur>0)?this.cur-1:h.length-1;var g=h[this.cur];this.highlightSuggestion(g);this.pickvalue(g.firstChild.nodeValue)}};this.selectRange=function(g,h){if(this.textbox.createTextRange){var i=this.textbox.createTextRange();i.moveStart("character",g);i.moveEnd("character",h-this.textbox.value.length);i.select()}else{if(this.textbox.setSelectionRange){this.textbox.setSelectionRange(g,h)}}this.textbox.focus()};this.showSuggestions=function(m){this.cur=-1;var j=null;this.setupLayer();if(gx.dom.shouldPurge()){gx.dom.purge(this.layer,true)}this.layer.innerHTML="";if(!this.IFrameControl){var l=false;var h="gxAutosuggestIFrame";this.IFrameControl=gx.dom.byId(h);if(!this.IFrameControl){l=true;this.IFrameControl=document.createElement("IFRAME");
this.IFrameControl.src="about:blank";this.IFrameControl.id=h}this.IFrameControl.style.zIndex=1;this.IFrameControl.style.visibility="hidden";this.IFrameControl.style.position="absolute";this.IFrameControl.frameBorder="0";if(l){document.body.appendChild(this.IFrameControl)}}var g=m.length;for(var k=0;k<g;k++){j=document.createElement("div");j.appendChild(document.createTextNode(m[k].d));j.style.width=this.textbox.offsetWidth;this.layer.appendChild(j)}this.layer.style.left=this.getLeft()+"px";this.layer.style.top=(this.getTop()+this.textbox.offsetHeight)+"px";this.layer.style.visibility="visible";this.layer.style.zIndex=2;this.IFrameControl.style.top=this.layer.style.top;this.IFrameControl.style.left=this.layer.style.left;this.IFrameControl.style.height=this.layer.offsetHeight;this.IFrameControl.style.width=this.layer.offsetWidth;this.IFrameControl.style.visibility="visible"};this.typeAhead=function(i){if(this.textbox.createTextRange||this.textbox.setSelectionRange){var g=this.textbox.value.length;this.pickvalue(i);var h=i.length;if(g<h){this.selectRange(g,h)}}};this.pickvalue=function(h){var g=this.aSuggestions.length;for(var j=0;j<g;j++){if(this.aSuggestions[j].d==h){this.textbox.value=h;gx.evt.execOnchange(this.textbox);return}}};this.autosuggest=function(i,h){this.aSuggestions=i;var g=this.aSuggestions.length;if(h&this.aSuggestions!=null&&g==1){this.typeAhead(this.aSuggestions[0].d);this.hideSuggestions()}else{if(this.textbox==gx.csv.lastControl&&this.aSuggestions!=null&&g>0){if((g==1)&&(this.aSuggestions[0].d!=this.textbox)||(g>1)){this.showSuggestions(this.aSuggestions);return}}this.hideSuggestions()}};this.createDropDown=function(){var h="gxAutosuggestElement";var g=false;this.layer=gx.dom.byId(h);if(!this.layer){g=true;this.layer=document.createElement("div");this.layer.className="suggestions";this.layer.id=h}this.setupLayer();if(g){document.body.appendChild(this.layer)}};this.setupLayer=function(){var g=this;this.layer.style.visibility="hidden";this.layer.style.width=this.textbox.offsetWidth;this.layer.onmousedown=this.layer.onmouseup=this.layer.onmouseover=function(h){h=h||window.event;oTarget=gx.evt.source(h);if(h.type=="mousedown"){gx.evt.cancel(h,true);g.pickvalue(oTarget.firstChild.nodeValue);g.hideSuggestions();window.setTimeout(function(){gx.fn.setFocus(g.textbox)},100)}else{if(h.type=="mouseover"){g.highlightSuggestion(oTarget)}else{g.textbox.focus()}}}};this.getLeft=function(){var h=this.textbox;var g=0;while(h.tagName!="BODY"){g+=h.offsetLeft;h=h.offsetParent}h=this.textbox;while(h.tagName!="BODY"){g-=h.scrollLeft;h=h.parentNode}return g};this.getTop=function(){var h=this.textbox;var g=0;while(h.tagName!="BODY"){g+=h.offsetTop;h=h.offsetParent}h=this.textbox;while(h.tagName!="BODY"){g-=h.scrollTop;h=h.parentNode}return g};this.handleKeyDown=function(g){switch(g.keyCode){case 38:this.previousSuggestion();break;case 40:this.nextSuggestion();break;case 13:this.hideSuggestions();break}};this.handleKeyUp=function(g){var h=g.keyCode;if(h==9){this.hideSuggestions()
}else{if(h==8||h==46){this.requestSuggestions(this,this.provider,false)}else{if(!(h<32||(h>=33&&h<46)||(h>=112&&h<=123))){this.requestSuggestions(this,this.provider,this.typeahead)}}}};this.init()},suggestProvider:function(ControlId,ControlRefresh,CtrlSvc){this.ControlId=ControlId;this.ControlRefresh=ControlRefresh;this.CtrlSvc=CtrlSvc;this.requestSuggestions=function(oAutoSuggestControl,bTypeAhead){var backcall="gx.fx.returnSuggestValues('"+this.VarRefresh+"',";var sURL=gx.ajax.objectUrl()+"?";var sParms="gxajaxSuggest_"+this.CtrlSvc;var len=this.ControlId.length;for(var i=0;i<len;i++){sParms+=","+encodeURIComponent(eval(this.ControlId[i]))}sParms+=","+encodeURIComponent(gx.fn.getControlValue_impl(this.ControlRefresh));len=oAutoSuggestControl.sdtParms.length;for(var i=0;i<len;i++){sParms+=","+encodeURIComponent(eval(oAutoSuggestControl.sdtParms[i]))}sURL+=gx.ajax.encryptParms(gx.O,sParms);this.values=gx.http.callBackend(backcall,sURL,")",false,gx.http.modes.retval,true);if(this.values){oAutoSuggestControl.autosuggest(this.values,bTypeAhead)}else{oAutoSuggestControl.hideSuggestions()}}},returnSuggestValues:function(b,a){return a},addElement:function(a,b,d){if(this.elementExists(a,b,d)){return}var c=b.id;if(d==true){c+=b.types.sort().join("")}a.splice(0,0,b);a[c]=b},elementExists:function(a,b,d){var c=b.id;if(d==true){c+=b.types.sort().join("")}if((a[c]!=undefined)&&(a[c]!=null)){return true}return false},deleteElement:function(b,c,f){var h=c;if(f!=undefined){h+=f.sort().join("")}var e=b[h];if((e!=undefined)&&(e!=null)){delete b[h]}var a=b.length;for(var d=0;d<a;d++){var g=b[d];if(g.id==c){if(f!=undefined){if(this.matchingTypes(f,g.types)){b.removeAt(d);break}}else{b.removeAt(d);break}}}return b},matchingTypes:function(f,g){var a=g.length;for(var d=0;d<a;d++){var e=false;var c=f.length;for(var b=0;b<c;b++){if(g[d].toLowerCase()==f[b].toLowerCase()){e=true}}if(!e){return false}}return true},findControl:function(a,e,b){var d=gx.dom.el(b);if(d!=null){return d}d=gx.dom.el("gxHTMLWrp"+b);if(d!=null){return d}var c=new RegExp("^"+b+"_(?:(?:[0-9]){4})+$");if(a!=null&&c.test(a.id)){return a}return null},isUnderMouse:function(b){var e=gx.evt.mouse.x;var c=gx.evt.mouse.y;var d=gx.dom.position(b);var a=gx.dom.dimensions(b);if((e>=d.x)&&(e<=(d.x+a.w))&&(c>=d.y)&&(c<=(d.y+a.h))){return true}return false},dom:{generics:[],dblclicks:[],getEventHandlers:function(a){if(a=="dblclick"){return this.dblclicks}return this.generics},addEventHandler:function(e,f,b,d){b=gx.lang.emptyObject(e)?b:e.CmpContext+b;var c={id:f+b,cId:b,type:f,obj:e,hdl:d};var a=this.getEventHandlers(f);gx.fx.addElement(a,c,false)},raiseEvent:function(h,c){var b=gx.evt.source(c);var d=this.getEventHandlers(h);var a=d.length;for(var f=0;f<a;f++){var e=d[f];var g=gx.fx.findControl(b,e.obj,e.cId);if(g!=null){if(gx.fx.isUnderMouse(g)){e.hdl.call(e.obj)}}}},highlight:function(e,a,d){var c=gx.color.fromRGB(a[0],a[1],a[2]);var f=gx.dom.getStyle(e,"backgroundColor");var b=(f=="transparent"||f=="rgba(0, 0, 0, 0)");
return{play:function(){e.style.backgroundColor=c.Html;setTimeout(this.end,d)},end:function(){var g=f;if(b){g="transparent"}e.style.backgroundColor=g}}}},obs:{observers:[],addObserver:function(d,c,b,a){new gx.thread.Mutex(this,this.addObserverSync,arguments)},addObserverSync:function(d,c,b,a){if(this.indexOf(d,c,b)<0){this.observers.push({e:d,o:c,f:b,cfg:a})}},deleteObserver:function(c,b,a){new gx.thread.Mutex(this,this.deleteObserverSync,[c,b,a])},deleteObserverSync:function(d,c,b){var a=this.indexOf(d,c,b);if(a>=0){this.observers.removeAt(a)}},removeAll:function(){this.observers=[]},indexOf:function(e,d,c){var a=this.observers.length;for(var b=0;b<a;b++){var f=this.observers[b];if(f.e==e&&f.o==d&&f.f==c){return b}}return -1},notify:function(g,d){if(!d){d=[]}var a=this.observers.length;var c=[];for(var b=0;b<a;b++){var h=this.observers[b];if(h.e==g){try{h.f.apply(h.o,d)}catch(f){gx.dbg.logEx(f,"gxfx.js","gx.obs.notify")}finally{if(h.cfg&&h.cfg.single){c.push(b)}}}}if(c.length>0){for(var b=0,a=c.length;b<a;b++){this.observers.removeAt(c[b])}}}},dnd:{obj:null,dragCtrl:null,clonCtrl:null,sources:[],targets:[],dropCtrl:null,noDropCtrl:null,toHdl:null,drag:function(c,a,b){if(b!=undefined){gx.evt.setEventRow(c,this.dragCtrl);this.obj=b.call(c,this.dragCtrl);this.obj.gxDragTypes=a}},drop:function(b,c,a){if(a!=undefined){a.call(c,b,this.dragCtrl,this.obj)}},noDrop:function(){var a=this.noDropCtrl;if(a!=null){if(a.gxDndClassName!=undefined){a.className=a.gxDndClassName+"NoAcceptDrag"}}},out:function(){var a=this.dropCtrl;if(a!=null){if(a.gxClassName!=undefined){a.className=a.gxClassName}}this.dropCtrl=null;var a=this.noDropCtrl;if(a!=null){if(a.gxClassName!=undefined){a.className=a.gxClassName}}this.noDropCtrl=null},over:function(){var a=this.dropCtrl;if(a!=null){if(a.gxDndClassName!=undefined){a.className=a.gxDndClassName+"AcceptDrag"}}},deleteClonControl:function(){if(this.clonCtrl!=null){gx.dom.removeControlSafe(this.clonCtrl)}this.clonCtrl=null},restoreControl:function(){var a=this.clonCtrl;if(a!=null){if(this.toHdl==null){a.dropLeft=parseFloat(a.style.left||"0");a.dropTop=parseFloat(a.style.top||"0");this.toHdl=setInterval("gx.fx.dnd.restoreControl()",2)}if(this.controlRestored()){clearInterval(this.toHdl);this.toHdl=null;this.deleteClonControl()}else{var b=this.nextCoords();this.moveDragControl(b.X,b.Y)}}},nextCoords:function(){var c=this.clonCtrl;var e=parseFloat(c.style.left||"0");var d=parseFloat(c.style.top||"0");var b=0;var a=0;if(e>=d){b=e-1;a=c.dropTop-(((c.dropTop-c.originalTop)*(c.dropLeft-b))/(c.dropLeft-c.originalLeft))}else{a=d-1;b=c.dropLeft-(((c.dropTop-a)*(c.dropLeft-c.originalLeft))/(c.dropTop-c.originalTop))}if(b<=c.originalLeft){b=c.originalLeft}if(a<=c.originalTop){a=c.originalTop}return{X:b,Y:a}},moveControl:function(a){if(this.clonCtrl==null){var c=10;var b=document.createElement("DIV");b.style.position="absolute";if(a.gxDndClassName!=undefined){b.className=a.gxDndClassName+"Dragging"}if(gx.dom.shouldPurge()){gx.dom.purge(b,true)
}b.innerHTML=this.dragInfo();gx.fn.setOpacity(50,b);document.body.appendChild(b);b.originalLeft=gx.evt.mouse.x-c;b.originalTop=gx.evt.mouse.y-c;b.diffLeft=c;b.diffTop=c;this.clonCtrl=b}this.moveDragControl(gx.evt.mouse.x,gx.evt.mouse.y)},controlRestored:function(){var c=this.clonCtrl;if(c==null){return true}var e=parseFloat(c.style.left||"0");var d=parseFloat(c.style.top||"0");var b=e-c.originalLeft;var a=d-c.originalTop;if((b<=0)&&(a<=0)){return true}return false},moveDragControl:function(d,c){try{var a=this.clonCtrl;if(a!=null){a.style.left=(d-a.diffLeft)+"px";a.style.top=(c-a.diffTop)+"px"}}catch(b){this.deleteClonControl()}},dragInfo:function(){if(this.obj!=null){var a="";var c="";for(var d in this.obj){if(d!="gxDragTypes"){var b=[a];if(typeof(this.obj[d])=="function"){continue}c+=d+": "+this.obj[d]+"</br>";a=b[0]}if(a>=5){c+="...";break}a++}return c}return""},deleteHandlers:function(a){new gx.thread.Mutex(this,this.deleteHandlersSync,[a])},deleteHandlersSync:function(f){var c=[];var a=this.sources.length;for(var b=0;b<a;b++){var d=this.sources[b];if(d.obj!=f){c.push(d)}}this.sources=c;c=[];a=this.targets.length;for(var b=0;b<a;b++){var e=this.targets[b];if(e.obj!=f){c.push(e)}}this.targets=c},addSource:function(e,b,c,a,d){new gx.thread.Mutex(this,this.addSourceSync,[e,b,c,a,d])},addSourceSync:function(f,c,d,b,e){c=gx.lang.emptyObject(f)?c:f.CmpContext+c;var a={id:c,cssClass:d,types:b,obj:f,hdl:e};gx.fx.addElement(this.sources,a,false)},addTarget:function(e,b,c,a,d){new gx.thread.Mutex(this,this.addTargetSync,[e,b,c,a,d])},addTargetSync:function(e,b,c,a,d){b=gx.lang.emptyObject(e)?b:e.CmpContext+b;var f={id:b,cssClass:c,types:a,obj:e,hdl:d};gx.fx.addElement(this.targets,f,true)},deleteSource:function(a){new gx.thread.Mutex(this,this.deleteSourceSync,[a])},deleteSourceSync:function(a){this.sources=gx.fx.deleteElement(this.sources,a)},getSource:function(c){var b=gx.evt.source(c);var a=this.sources.length;for(var d=0;d<a;d++){var e=this.sources[d];this.dragCtrl=gx.fx.findControl(b,e.obj,e.id);var f=this.dragCtrl;if(f!=null){f.gxClassName=f.className;f.gxDndClassName=e.cssClass;if(gx.fx.isUnderMouse(f)){return e}}}this.dragCtrl=null;this.obj=null;return null},getTarget:function(c,e){var b=gx.evt.source(c);var a=this.targets.length;for(var d=0;d<a;d++){var g=this.targets[d];var f=gx.fx.findControl(b,g.obj,g.id);if(f!=null){f.gxClassName=f.className;f.gxDndClassName=g.cssClass;if(gx.fx.isUnderMouse(f)){if(gx.fx.matchingTypes(e,g.types)){this.noDropCtrl=null;this.dropCtrl=f;return g}else{this.out();this.noDropCtrl=f;this.noDrop();return null}}}}this.out();return null}},ctx:{setters:[],trackers:[],deleteHandlers:function(a){new gx.thread.Mutex(this,this.deleteHandlersSync,[a])},deleteHandlersSync:function(e){var c=[];var a=this.setters.length;for(var b=0;b<a;b++){var f=this.setters[b];if(f.obj!=e){c.push(f)}}this.setters=c;c=[];a=this.trackers.length;for(var b=0;b<a;b++){var d=this.trackers[b];if(d.obj!=e){c.push(d)}}this.trackers=c},addSetter:function(e,a,b,d,c){new gx.thread.Mutex(this,this.addSetterSync,[e,a,b,d,c])
},addSetterSync:function(e,a,b,d,c){a=gx.lang.emptyObject(e)?a:e.CmpContext+a;var f={id:a,cssClass:b,types:d,obj:e,hdl:c};gx.fx.addElement(this.setters,f,false)},addTracker:function(c,b,a){new gx.thread.Mutex(this,this.addTrackerSync,[c,b,a])},addTrackerSync:function(d,c,a){ctrlId=d.CmpContext+d.IsMasterPage.toString();var b={id:ctrlId,cssClass:"",types:c,obj:d,hdl:a};gx.fx.addElement(this.trackers,b,true)},deleteSetter:function(a){new gx.thread.Mutex(this,this.deleteSetterSync,[a])},deleteSetterSync:function(a){this.setters=gx.fx.deleteElement(this.setters,a)},notify:function(b,c,a){new gx.thread.Mutex(this,this.notifySync,[b,c,a])},notifySync:function(c,j,g){if(c&&c.forcedFocus){c.forcedFocus=false;return}var a=gx.lang.emptyObject;var e=null;if(a(j)||a(g)){var k=this.setters.length;for(var f=0;f<k;f++){var b=this.setters[f];if(!a(c)){if(c.id==b.id){e=c;gx.evt.setEventRow(b.obj,e);j=b.types;g=b.hdl.call(b.obj,e);break}}else{e=gx.fx.findControl(null,b.obj,b.id);if(e!=null){if(a(e.onfocus)){if(gx.fx.isUnderMouse(e)){gx.evt.setEventRow(b.obj,e);j=b.types;g=b.hdl.call(b.obj,e);break}}}}}}if(!a(j)&&(g!=null||g=="")){var h=this.trackers.length;for(var f=0;f<h;f++){var d=this.trackers[f];if(gx.fx.matchingTypes(j,d.types)){d.hdl.call(d.obj,null,e,g)}}}}}};