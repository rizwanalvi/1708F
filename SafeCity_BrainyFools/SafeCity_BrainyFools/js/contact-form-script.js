
$(document).ready(function() {
    // Generate a simple captcha
    
    $('#contactForm')
        .formValidation({
            framework: 'bootstrap',
            icon: {
                valid: 'glyphicon glyphicon-ok',
                invalid: 'glyphicon glyphicon-remove',
                validating: 'glyphicon glyphicon-refresh'
            },
            fields: {
                firstName: {
                    row: '.col-xs-4',
                    validators: {
                        notEmpty: {
                            message: 'The first name is required'
                        }
                    }
                },
                lastName: {
                    row: '.col-xs-4',
                    validators: {
                        notEmpty: {
                            message: 'The last name is required'
                        }
                    }
                },
                phoneNumber: {
                    validators: {
                        notEmpty: {
                            message: 'The phone number is required'
                        },
                        regexp: {
                            message: 'The phone number can only contain the digits, spaces, -, (, ), + and .',
                            regexp: /^[0-9\s\-()+\.]+$/
                        }
                    }
                },
                email: {
                    validators: {
                        notEmpty: {
                            message: 'The email address is required'
                        },
                        emailAddress: {
                            message: 'The input is not a valid email address'
                        }
                    }
                },
                message: {
                    validators: {
                        notEmpty: {
                            message: 'The message is required'
                        },
                        stringLength: {
                            max: 700,
                            message: 'The message must be less than 700 characters long'
                        }
                    }
                }
            }
        })
        .on('err.form.fv', function(e) {
            // Regenerate the captcha
        
        });
});