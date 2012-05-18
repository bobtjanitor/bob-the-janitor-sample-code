﻿/*
* Infragistics.Web.ClientUI Editors 12.1.20121.1010
*
* Copyright (c) 2011-2012 Infragistics Inc.
*
* http://www.infragistics.com/
*
* Depends on:
* jquery-1.4.4.js
* jquery.ui.core.js
* jquery.ui.widget.js
*
* Example to use:
*	<script type="text/javascript">
*	$(function () {
*		$('#rating1').igRating({ voteCount:3, value:0.5, vertical:true });
*	});
*	</script>
*	<div id="rating1"></div>
*/
(function(a){var b=function(c){return c===null||c===undefined||(typeof c==="number"&&isNaN(c))};a.widget("ui.igRating",{options:{vertical:false,value:null,valueHover:null,voteCount:5,voteWidth:0,voteHeight:0,swapDirection:false,valueAsPercent:true,focusable:true,precision:"whole",precisionZeroVote:0.25,roundedDecimalPlaces:3,theme:null,validatorOptions:null,cssVotes:null},css:{normal:"ui-igrating ui-state-default ui-widget-content",active:"ui-igrating-active",selected:"ui-igrating-selected ui-state-highlight",hover:"ui-igrating-hover ui-state-hover",vote:"ui-igrating-vote ui-icon ui-icon-star",voteSelected:"ui-igrating-voteselected",voteDisabled:"ui-igrating-votedisabled ui-state-disabled",voteHover:"ui-igrating-votehover",voteDisabledSelected:"ui-igrating-votedisabledselected ui-state-disabled"},events:{hoverChange:null,valueChange:null},_create:function(){var i,c,f,l={fontSize:"1px",width:"100%",height:"100%",position:"relative",overflow:"hidden"},k=this.options,g=this.element,j=this,e=this.css,d=this._count(k),m=g[0].style,h=k.inputName;j._old={width:m.width,height:m.height,html:g[0].innerHTML};if(!h){g[0].innerHTML=""}if(k.theme){g.addClass(k.theme)}j._swap=k.swapDirection;j._rtl=g.css("direction")==="rtl";if(j._rtl){j._swap=!j._swap;g.css("direction","ltr")}j._hasHov=0;f=j._elem=a("<div/>").css(l).addClass(e.normal).appendTo(g).bind(j._evts={mousedown:function(n){j._doEvt(n,1)},mousemove:function(n){j._doEvt(n,2)},mouseleave:function(n){j._doEvt(n,3)}});c=a("<div/>").css(l).appendTo(f);if(k.focusable){m={left:"5px",top:"5px",opacity:0.1,position:"absolute",width:"1px",height:"1px",padding:"0px",zIndex:-1,border:"0px",outline:0};j._foc=a('<input type="button"/>').css(m).appendTo(c).focus(function(n){if(k.disabled||j._fcs){return}j._fcs=1;if(j._hasHov<2){j._hasHov+=2}if(j._hov){j._doVal(j._valH,1,n);j._hov.css("visibility","visible")}j._elem.addClass(e.active)}).blur(function(){if(k.disabled||!j._fcs){return}j._fcs=null;j._hasHov%=2;if(j._hov&&j._hasHov===0){j._hov.css("visibility","hidden")}j._elem.removeClass(e.active)}).keydown(function(p){var t,n=0,r=p.keyCode,s=a.ui.keyCode,v=j._valH,u=j._swap?-1:1,w=k.vertical,o=1/j._count(k);if(k.disabled){return}t=v;o/=j._prec(k);if(r===s.SPACE||r===s.ENTER){j._doVal(v,false,p);return}if(r===s.HOME){v=0}else{if(r===s.END){v=1}else{if(r===s.PAGE_DOWN){v+=o*4}else{if(r===s.PAGE_UP){v-=o*4}else{if(r===s.UP&&w){v+=(n=-o*u)}else{if(r===s.DOWN&&w){v+=(n=o*u)}else{if(r===s.LEFT&&!w){v+=(n=-o*u)}else{if(r===s.RIGHT&&!w){v+=(n=o*u)}}}}}}}}if(r>32&&r<41){try{p.preventDefault();p.stopPropagation()}catch(q){}}for(r=0;r<3;r++){if(t!==(v=Math.max(Math.min(v,1),0))&&j._doVal(v,1,p)&&n){v+=n}else{break}}})}j._doVotes(k,c);if(h){i=a('input[name="'+h+'"]');if(i.length<=0){i=a("#"+h)}m=i[0]?i[0].value:null;if(m){k.value=j._toNum(m,k)}}j._val=j._toNum(k.value,k);m=k.valueHover;j._valH=b(m)?j._val:j._toNum(m,k);if(!k.valueAsPercent){j._val/=d;j._valH/=d}j.validator();j._set=true;j._doVal(j._val,null,i?2:i);j._doVal(j._valH,1);delete j._set},_toNum:function(d,c){if(!d){return 0}c=c._vsFormat;if(typeof d==="string"){d=parseFloat(c?d.replace(c,"_").replace(/[`,\. \':]/g,"").replace("_","."):d)}return(isNaN(d)||d<0)?0:d},_count:function(c){c=parseInt(c.voteCount,10);return isNaN(c)?5:Math.max(c,1)},_doVotes:function(s,d){var p,t,h,n,y,j,u,g,x=d,e=this._count(s),v={width:"100%",height:"100%"},c={left:"0px",top:"0px",position:"absolute",overflow:"hidden",border:"none",background:"none"},q=-1,r=this,f=this.css,k=this._elem,l=this.element,w={touchstart:function(i){i.preventDefault();a(this).trigger("mousedown")}};if(!d){d=r._div.parent();r._div.remove();r._hov.remove();r._sel.remove();r._selSwap=r._hovSwap=null}j=r._div=a("<div/>").addClass(f.vote).css(c).appendTo(d);if(!s.vertical){j.css("whiteSpace","nowrap")}n=parseInt(s.voteHeight,10);y=parseInt(s.voteWidth,10);if(isNaN(n)||n<2){n=j.css("height");n=(!n||n.indexOf("px")<1)?16:parseInt(n,10)}if(isNaN(y)||y<2){y=j.css("width");y=(!y||y.indexOf("px")<1)?16:parseInt(y,10)}j.removeClass(f.vote);t=r._sel=a("<div/>").addClass(f.selected).css(v).css(c).appendTo(d);if(!s.vertical){t.css("whiteSpace","nowrap")}p=r._hov=a("<div/>").addClass(f.hover).css(v).css(c).css("visibility","hidden").appendTo(d);if(!s.vertical){p.css("whiteSpace","nowrap")}if(r._swap&&!s.vertical){r._hovSwap=p=a("<div/>").css(v).appendTo(r._hov);r._selSwap=t=a("<div/>").css(v).appendTo(r._sel)}h={display:s.vertical?"block":"inline-block",width:y,height:n,textIndent:"0px",overflow:"visible"};while(++q<e){u=a("<span />").addClass(f.vote).css(h).appendTo(j).bind(w);if(s.disabled){u.addClass(f.voteDisabled)}g=s.cssVotes?s.cssVotes[q]:null;if(g&&g[0]){u.addClass(g[0])}u[0]._i=q;u=a("<span />").addClass(f.vote).addClass(f.voteSelected).css(h).appendTo(t).bind(w);if(s.disabled){u.addClass(f.voteDisabledSelected)}if(g&&g[1]){u.addClass(g[1])}u[0]._i=q;if(r._swap&&!r._selSwap){r._selSwap=u}u=a("<span />").addClass(f.vote).addClass(f.voteHover).css(h).appendTo(p).bind(w);if(g&&g[2]){u.addClass(g[2])}u[0]._i=q;if(r._swap&&!r._hovSwap){r._hovSwap=u}}if(s.vertical){r._size=n;n*=e}else{r._size=y;y*=e}k.css({height:n+"px",width:y+"px"});try{n+=((q=Math.max(k.outerHeight()-k.innerHeight(),0))>10)?2:q;y+=((q=Math.max(k.outerWidth()-k.innerWidth(),0))>10)?2:q}catch(m){}l.css({height:n+"px",width:y+"px"});j.css(v);if(!x){r.value(r.value())}},validator:function(c){var e=this.options.validatorOptions,d=this._foc,f=this._validator;if(f&&(c||!e)){f.destroy();delete this._validator}else{if(!f&&!c&&e&&d&&d.igValidator){e.element=this.element.find(":first-child");this._validator=d.igValidator(e).data("igValidator")}}return this._validator},validate:function(){return this._validator?this._validator.validate():null},_doEvt:function(c,f){var g,d=this,e=this.options;if(e.disabled){return}if(f===3){d._hasHov-=d._hasHov%2;if(d._hov&&d._hasHov===0){d._hov[0].style.visibility="hidden"}return}g=d._valFromEvt(c);if(g<0){return}if(f===1){if(!d._sel){return}g=d._lastHov||g;d._doVal(g,false,c);d._doVal(g,1,c);if(d._foc&&document.hasFocus&&!document.hasFocus()){return setTimeout(function(){d.focus()},0)}else{d.focus()}}if(f===2){d._lastHov=g;if(!d._hov){return}if(d._hasHov%2===0){d._hasHov++}d._hov[0].style.visibility="visible";d._doVal(g,1,c)}c.preventDefault()},_setOption:function(e,h){var g,c,d,f=this.options;if(f[e]===h||e==="swapDirection"||e==="vertical"||e==="focusable"){return}c=this._count(f);if(e==="disabled"){g=a("SPAN",this._div);d=this.css.voteDisabled;if(g.length!==c){return}if(h){g.addClass(d)}else{g.removeClass(d)}g=a("SPAN",this._sel);d=this.css.voteDisabledSelected;if(g.length!==c&&this._selSwap){g=a("SPAN",this._selSwap)}if(g.length===c){if(h){g.addClass(d)}else{g.removeClass(d)}}}if(e==="theme"){if(f.theme){this.element.removeClass(f.theme)}if(h){this.element.addClass(h)}}this._set=true;f[e]=h;if(e==="precision"||e==="valueAsPercent"){this._doVal(this._val,false,1);this._doVal(this._valH,1,1)}if(e.indexOf("vote")===0||e==="theme"||e==="cssVotes"){this._doVotes(f)}if(e.indexOf("value")>=0){this._doVal(h,e.length>6,1,1)}if(e==="validatorOptions"){this.validator()}delete this._set},_evtOffset:function(c,g){var f,d=c.originalEvent||c,e="offset"+g;if(b(f=c[e])){if(b(f=d[e])){if(b(f=c[e="layer"+g])){f=d[e]}}}return f||1},_valFromEvt:function(c){var h,d,k,g,e,f=this.options,j=c?c.target:null;e=(j&&j.nodeName==="SPAN")?j._i:null;if(b(e)){return -1}if(!j.unselectable){j.unselectable="on"}g=this._evtOffset(c,f.vertical?"Y":"X");h=this._size;d=-(f.vertical?j.offsetTop:j.offsetLeft);if(this._swap&&a.browser.mozilla&&d<h){g+=d}h*=e;if(h>g){g+=h}k=g/this._count(f)/this._size;if(this._swap){k=1-k}return Math.max(Math.min(k,1),0)},_doVal:function(n,e,d,l){var f,g,m,c,h=this.options,j=e?this._hov:this._sel,i=this._size,k=this._swap?(e?this._hovSwap:this._selSwap):null;if(j){j=j[0];if(j){j=j.style}}if(!j){return}c=this._count(h);if(l){n=parseFloat(n)}if(isNaN(n)){n=-1}else{if(l&&!h.valueAsPercent){n/=c}}if(d&&d.type&&n>=0){l=this._fixVal(e?this._valH:this._val,1);m=this._fixVal(n,1);if(l===m){return 1}if(!this._trigger(e?"hoverChange":"valueChange",d,{value:m,oldValue:l})){return}}if(n<0&&e){n=this._val}n=this._fixVal(n);if(d){l=this._round(h.valueAsPercent?n:n*c,h);if(e){this._valH=n;h.valueHover=l}else{if(d!==2){this._val=n;h.value=l}f=h.inputName;if(f){g=a('input[name="'+f+'"]');if(g.length===0){g=a('<input type="hidden" name="'+f+'" />').appendTo(this.element.parent())}m=h._vsFormat;g.val(m?l.toString().replace(".",m):l)}}}if(!e&&this._foc){this._foc.val(this._fixVal(n,1))}if(k){n=1-n}n=Math.floor(n*i*c+0.3);n+="px";if(k){k=k[0];if(k){k=k.style}}if(h.vertical){if(k){j.top=n;k.marginTop="-"+n}else{j.height=n}}else{if(k){j.left=n;k.marginLeft="-"+n}else{j.width=n}}},_prec:function(c){c=this._set?null:c.precision;if(c){c=c.toLowerCase()}return(c==="half")?2:((c==="whole")?1:4)},_fixVal:function(h,e,g){var d,c,f=this.options;g=g||this._prec(f);c=this._count(f);h=Math.max(Math.min(h,1),0);if(g<4){d=c*g;h*=d;h=(h<f.precisionZeroVote)?0:Math.floor(Math.floor(h+0.99)+0.499*g)/d}if(!e){return h}if(!f.valueAsPercent){h*=c;h=(g>1)?h:Math.floor(h+0.1)}return this._round(h,f)},_round:function(f,d){var e=1,c=parseInt(d.roundedDecimalPlaces,10);if(isNaN(c)||c<0){return f}c=Math.min(15,Math.max(c,(this._prec(d)<4)?3:(d.valueAsPercent?1:0)));while(c-->0){e*=10}return Math.round(f*e)/e},value:function(c){if(typeof c!=="number"){return this._fixVal(this._val,1,4)}this._set=true;this._doVal(c,false,1,1);delete this._set;return this},valueHover:function(c){if(typeof c!=="number"){return this._fixVal(this._valH,1,4)}this._set=true;this._doVal(c,1,1,1);delete this._set;return this},hasFocus:function(){return this._fcs===1},focus:function(){if(this._foc){try{this._foc[0].focus()}catch(c){}}return this},destroy:function(){var d=this.options,f=this._old,c=this.element;if(!this._elem){return this}this.validator(1);if(this._foc){this._foc.unbind().remove()}this._elem.remove();if(d.theme){c.removeClass(d.theme)}c[0].style.width=f.width;c[0].style.height=f.height;if(!d.inputName){c[0].innerHTML=f.html}if(this._rtl){c.css("direction","rtl")}a.Widget.prototype.destroy.apply(this,arguments);this._elem=this._hov=this._sel=this._selSwap=this._hovSwap=this._foc=this._evts=null;return this}});a.extend(a.ui.igRating,{version:"12.1.20121.1010"})}(jQuery));(function(a){a(document).ready(function(){a.ig=a.ig||{};if(a.ig.TrialWatermark===undefined){var b=a("#__ig_wm__").length>0?a("#__ig_wm__"):a('<div id="__ig_wm__"></div>').appendTo(document.body);b.css({width:a(document.body).width()||1280,height:a(document.body).height()||1024,position:"absolute",top:0,left:0,zIndex:-1}).addClass("ui-igtrialwatermark");a.ig.TrialWatermark=true}})}(jQuery));