jQuery(function ($) {
    var $bodyEl = $('body'),
        $sidedrawerEl = $('#sidedrawer');


    var profileData = $('#ProfileData');
    // ==========================================================================
    // Toggle Sidedrawer
    // ==========================================================================
    function showSidedrawer() {

        // show overlay
        var options = {
            onclose: function () {
                $sidedrawerEl
                  .removeClass('active')
                  .appendTo(document.body);
            }
        };

        var $overlayEl = $(mui.overlay('on', options));

        // show element
        $sidedrawerEl.appendTo($overlayEl);
        setTimeout(function () {
            $sidedrawerEl.addClass('active');
        }, 20);  
    }


    function hideSidedrawer() {
        $bodyEl.toggleClass('hide-sidedrawer');
    }


    $('.js-show-sidedrawer').on('click', function () { showSidedrawer(); });
    $('.js-hide-sidedrawer').on('click', function () { hideSidedrawer(); profileData.toggle(); });

    // ==========================================================================
    // Animate menu
    // ==========================================================================
    var $titleEls = $('strong', $sidedrawerEl);

    $titleEls
      .next()
      .hide();

    $titleEls.on('click', function () {
        $(this).next().slideToggle(200);
    });
});
