<template>
<v-app>
<article>
		<section class="hero is-primary is-bold">
			<div class="hero-body">
				<div class="container">
					<h1 class="title">Vue.js</h1>
					<h2 class="subtitle">Getting data from a server</h2>
				</div>
			</div>
		</section>
    <nav>
      <div class="container">
        <div class="tabs">
          <ul>
            <li class="is-active"><a href="https://codepen.io/prongbang/pen/EgGrXR" target="_blank">Getting data from a server</a></li>
            <li><a href="https://codepen.io/prongbang/pen/KrYmPg" target="_blank">Postting data to a server</a></li>
          </ul>
      </div>
      </div>
    </nav>
		<section class="section">
			<div class="container">
				<div id="get-data-from-server-app">
					<div v-if="error != null" class="notification is-danger">
						<button class="delete"></button>
						{{error}}
					</div>
					<table v-if="locat != null" class="table">
            <thead>
              <tr>
                <th colspan="2">Data from a server</th>
              </tr>
            </thead>
						<tbody>
							<tr><td>as</td><td>{{locat.as}}</td></tr>
							<tr><td>city</td><td>{{locat.city}}</td></tr>
							<tr><td>country</td><td>{{locat.country}}</td></tr>
							<tr><td>countryCode</td><td>{{locat.countryCode}}</td></tr>
							<tr><td>isp</td><td>{{locat.isp}}</td></tr>
							<tr><td>lat</td><td>{{locat.lat}}</td></tr>
							<tr><td>lon</td><td>{{locat.lon}}</td></tr>
							<tr><td>org</td><td>{{locat.org}}</td></tr>
							<tr><td>query</td><td>{{locat.query}}</td></tr>
							<tr><td>region</td><td>{{locat.region}}</td></tr>
							<tr><td>regionName</td><td>{{locat.regionName}}</td></tr>
							<tr><td>status</td><td>{{locat.status}}</td></tr>
							<tr><td>timezone</td><td>{{locat.timezone}}</td></tr>
							<tr><td>zip</td><td>{{locat.zip}}</td></tr>
						</tbody>
					</table>
				</div>
			</div>
		</section>		
	</article>
<footer class="footer">
  <div class="container">
			<div class="content">
				<h3>Build with</h3>
				<ul>
				<li><a href="https://vuejs.org/guide" target="_blank">Vue.js guide</a></li>
					<li><a href="https://vuejs.org/examples" target="_blank">Vue.js example</a></li>
					<li><a href="https://github.com/vuejs/vue-resource" target="_blank">vue-resource</a></li>
					<li><a href="http://bulma.io" target="_blank">Bulma</a></li>
				</ul>
			</div>
		</div>
</footer>
</v-app>
</template>

<script>
var url = "";
new Vue({
				el:'#get-data-from-server-app',
				data: {
					locat: null,
                    error: null
				},
				created: function(){
					this.init();
				},
				methods: {
					init: function(){
						this.loadData();
					},
					loadData: function() { 
            
						this.$http.get(url).then((response) => { 
							if(!!response.body) {
								this.locat = response.body;
							}
						}, (response) => {
							this.error = response;
						});
            
            
					}
				}
			}); 
</script>