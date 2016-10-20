var uri = 'http://tamtamapi.azurewebsites.net/movies/';

function findByTitle() {

    var title = $("#title1").val();
    $.getJSON(uri + "getbytitle/" + title)
      .done(function (data) {

          buildHtmlContent(data);
      })
      .fail(function (jqXHR, textStatus, err) {
          alert("Error: " + err);
      });
};

function findByTitleAndYear() {
    var title = $("#title2").val();
    var year = $("#year").val();
    $.getJSON(uri + "getbytitleandyear/" + title + "/" + year)
      .done(function (data) {

          buildHtmlContent(data);
      })
      .fail(function (jqXHR, textStatus, err) {
          alert("Error: " + err);
      });
};


function buildHtmlContent(data) {
    var $tbody = $('<p>Not found.</p>');


    if (data.Movie.Title != null) {
        $tbody = $('<table class="table table-condensed"><thead><tr><th></th><th></th><th></th></tr></thead>');


        var aux = 0;
        $.each(data.Movie, function (k, v) {
            if (aux === 1) {
                var movie = "<td rowspan=19>";

                if (data.Movie.Poster !== "N/A")
                    movie += "<img height='250' width='200' src=" + data.Movie.Poster + "></img>";


                if (data.Video.items.length > 0)
                    movie += data.Video.items[0].id.embed + "</td>";
                else
                    movie += "Trailer not found.</td>";
            }

            $tbody.append('<tr><td>' + k + '</td><td>' + v + '</td>' + movie + '</tr>');

            aux++;
        });

        $tbody.append('<tbody></tbody></table><br/>');
    }


    $("#content").prepend($tbody);
};