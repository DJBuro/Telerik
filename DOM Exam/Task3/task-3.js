function solve() {
    return function (selector) {
        var template =
            '<div class="event-calendar">' +
                '<h2 class="header">Appointments for <span class="month">{{month}}</span> <span class="year">{{year}}</span></h2>' +
                '<div class="col-date">' +
                    '{{#each days}}' +
                   '<div class="date">{{this.day}}</div>' +
                    '<div class="events">' +
                        '{{#each this.events}}' +
                        '{{#if this.importance === "none"}}<div class="event {{importance}}" title="duration: {{duration}}">' +
                        '{{else}}<div class="event {{importance}}">{{/if}}' +
                        '{{#if this.title}}<div class="title">{{title}}</div>{{else}}<div class="title">Free slot</div>{{/if}}' +
                        '{{#if this.time}}<span class="time">at: {{this.time}}</span>{{/if}}' +
                    '</div>' +
                        '{{/each}}' +
                    '</div>' +
                        '{{/each}}' +
                    '</div>' +
                '</div>';

        document.getElementById(selector).innerHTML = template;
    };
}

module.exports = solve;