<!--==============================content================================-->
    <section id="content"><div class="ic"></div>
        <div class="main">
            <div class="container">
            	<strong>Pilihan</strong>
            	 <select name="item" id="item">
                  	<option>Menu</option>
					<option>Item</option>
					<option>Paket</option>
          	    </select>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<strong>Kategori</strong>
            	 <select name="item" id="item">
                  	<option>Kategori 1</option>
					<option>Kategori 2</option>
					<option>Kategori 3</option>
                  	<option>Kategori 4</option>
					<option>Kategori 5</option>
					<option>Kategori 6</option>
                  	<option>Kategori 7</option>
					<option>Kategori 8</option>
					<option>Kategori 9</option>
          	    </select>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <strong>Urutkan Berdasarkan</strong>
            	 <select name="item" id="item">
                  	<option>Kriteria 1</option>
					<option>Kriteria 2</option>
					<option>Kriteria 3</option>                  	
          	    </select>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input name="Refresh" type="button" value="Refresh">
                <br/><hr/><br/>
               	<div id="slider-2">
                	<?php
					$i = 1;
					dbConnect();
					$result = mysql_query("SELECT code, name, details, price FROM daftaritem") or error( mysql_error() );
					if (mysql_num_rows($result) > 0) {
						while($row = mysql_fetch_row($result)){
							if(($i % 2) != 0){
								echo ' <div><div class="p4">
                            <figure><a class="lightbox-image" href="images/'.$row[0].'.jpg" data-gal="prettyPhoto[prettyPhoto]"><img src="images/'.$row[0].'.jpg" alt="" width="200px" height="160px"></a></figure>
							<h5>'.$row[1].'</h5>
                            <p class="p1">'.$row[2].'</p>
                            <p class="p2"><strong class="color-2">Harga: Rp '.$row[3].'</strong></p>
                            <a class="button-1" href="index.php?order='.$row[0].'">Add to Cart</a>
                        </div>';
							}
							else{
								echo '<figure><a class="lightbox-image" href="images/'.$row[0].'.jpg" data-gal="prettyPhoto[prettyPhoto]"><img src="images/'.$row[0].'.jpg" alt="" width="200px" height="160px"></a></figure>
                        <h5>'.$row[1].'</h5>
                        <p class="p1">'.$row[2].'</p>
                        <p class="p2"><strong class="color-2">Harga: Rp '.$row[3].'</strong></p>
                        <a class="button-1" href="index.php?order='.$row[0].'">Add to Cart</a>
                  </div>';
							}
							$i = $i+1;
						}
					}
					?>                	
              </div>
          </div>
        </div>
    </section>