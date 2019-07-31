var path = require('path');

module.exports = {
    resolve: {
        extensions: ['.js', '.jsx']
    },
    mode: 'development',
    entry: {
        site: './wwwroot/src/scripts/site.js',
    },
    cache: true,
    output: {
        publicPath: '~/dist',
        path: path.resolve(__dirname, './wwwroot/dist/'),
    },
    //module: {
    //    rules: [
    //        {
    //            test: path.join(__dirname, '.'),
    //            exclude: /(node_modules)/,
    //            loader: 'babel-loader',
    //            query: {
    //                cacheDirectory: true,
    //                presets: ['es2015', 'react']
    //            }
    //        }
    //    ]
    //}
};