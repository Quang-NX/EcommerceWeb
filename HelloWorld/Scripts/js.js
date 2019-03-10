$(function() {
	
	$('.menu-user .col-icon').mouseover(function(event) {
		/* Act on the event */
		$('.nd-icon2').removeClass('show2');
		$('.nd-icon1').toggleClass('show1');
	});
	$('.menu-gach .col-icon').mouseover(function(event) {
		/* Act on the event */
		$('.nd-icon1').removeClass('show1');
		$('.nd-icon2').toggleClass('show2');
	});
	
	$(".back-to-top").click(function(event) {
		/* Act on the event */
		$("body,html").animate({scrollTop:0}, 1000)
	});
	//check width < 767 responsive
	$(window).resize(function(event) {
		/* Act on the event */
		if($(window).width()<767)
		{
			
		}
	});
});


