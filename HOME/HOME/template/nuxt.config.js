const webpack = require('webpack')
module.exports = {
	/*
	 ** Headers of the page
	 */
	head: {
		title: '大中华艺术网',
		meta: [{
				charset: 'utf-8'
			},
			{
				name: 'viewport',
				content: 'width=device-width, initial-scale=1'
			},
			{
				hid: 'description',
				name: 'description',
				content: 'Nuxt.js project'
			}
		],
		link: [{
			rel: 'icon',
			type: 'image/x-icon',
			href: '/favicon.ico'
		}]
	},
	css: [
		'~assets/main.css',
		'~assets/css/element.css',
		'~assets/css/element-icons.ttf',
		'~assets/css/element-icons.woff',
		'~assets/css/auction.css'
	],
	/*全局引入css样式*/
	/*
	 ** Customize the progress bar color
	 */
	loading: {
		color: '#3B8070'
	},
	/*
	 ** Build configuration
	 */
	build: {
		/*
		 ** Run ESLint on save
		 */
		// extend(config, {
		// 	isDev,
		// 	isClient
		// }) {
		// 	if(isDev && isClient) {
		// 		config.module.rules.push({
		// 			enforce: 'pre',
		// 			test: /\.(js|vue)$/,
		// 			loader: 'eslint-loader',
		// 			exclude: /(node_modules)/
		// 		})
		// 	}
		// },
		plugins: [
			new webpack.ProvidePlugin({
				'$': 'jquery' /*使用jquery插件*/
			})
		]
	},
	plugins: [{
		src: '~plugins/element-ui',
		ssr: false /*设置只在客户端使用*/
	}],
	vendor: ['element-ui'],
	/*配置vendor使其只打包一次*/
	modules: [
		'@nuxtjs/axios',
		'@nuxtjs/proxy'
	],
	proxy: [
		[
			'/api',
			{
				target: 'http://localhost:8082', // api主机
				pathRewrite: {
					'^/api': '/'
				}
			}
		]
	]

}