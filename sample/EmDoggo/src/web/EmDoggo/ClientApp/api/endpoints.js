// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Emeraude Client Builder.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

/**
 * @typedef CreatedResult
 * @property {string} createdEntityId
 */
/**
 * @typedef AddDogCommand
 * @property {string} name
 * @property {number} type
 * @property {number} breed
 */
/**
 * @typedef SimpleResult
 * @property {boolean} successed
 */
/**
 * @typedef EnumValueItem
 * @property {string} name
 * @property {number} value
 * @property {string} key
 */

export class DogsServiceAgent {

    /**
     * DogsApiController/AddDog
     * @param {AddDogCommand} request
     * @param {Object} queryParams
     * @param {Object} headers
     * @returns {Promise}
     */
    addDog(request, queryParams = null, headers = null) { 
        let url = new URL(`/api/dogs/add`, window.location.origin);
        if (queryParams != null) {
            url.search = new URLSearchParams(queryParams).toString();
        }
        return fetch(url, {
            method: 'POST',
            headers: headers || { 'Content-Type': 'application/json', 'Accept': 'application/json' },
            body: JSON.stringify(request),
            credentials: 'include'
        })
            .then(response => response.json());
    }
}

export class EmptyServiceAgent {

    /**
     * EmptyApiController/ExampleAction
     * @param {Object} queryParams
     * @param {Object} headers
     * @returns {Promise}
     */
    exampleAction(queryParams = null, headers = null) { 
        let url = new URL(`/api/empty/example`, window.location.origin);
        if (queryParams != null) {
            url.search = new URLSearchParams(queryParams).toString();
        }
        return fetch(url, {
            method: 'GET',
            headers: headers || { 'Content-Type': 'application/json', 'Accept': 'application/json' },
            credentials: 'include'
        })
            .then(response => response.json());
    }
}

export class EnumServiceAgent {

    /**
     * EnumApiController/GetEnumValueList
     * @param {string} enumTypeName
     * @param {Object} queryParams
     * @param {Object} headers
     * @returns {Promise}
     */
    getEnumValueList(enumTypeName, queryParams = null, headers = null) { 
        let url = new URL(`/api/enums/${enumTypeName}`, window.location.origin);
        if (queryParams != null) {
            url.search = new URLSearchParams(queryParams).toString();
        }
        return fetch(url, {
            method: 'GET',
            headers: headers || { 'Content-Type': 'application/json', 'Accept': 'application/json' },
            credentials: 'include'
        })
            .then(response => response.json());
    }

    /**
     * EnumApiController/GetEnumValue
     * @param {string} enumTypeName
     * @param {number} value
     * @param {Object} queryParams
     * @param {Object} headers
     * @returns {Promise}
     */
    getEnumValue(enumTypeName, value, queryParams = null, headers = null) { 
        let url = new URL(`/api/enums/${enumTypeName}/${value}`, window.location.origin);
        if (queryParams != null) {
            url.search = new URLSearchParams(queryParams).toString();
        }
        return fetch(url, {
            method: 'GET',
            headers: headers || { 'Content-Type': 'application/json', 'Accept': 'application/json' },
            credentials: 'include'
        })
            .then(response => response.json());
    }
}

/**
 * @type {DogsServiceAgent}
 */
export const dogsServiceAgent = new DogsServiceAgent();

/**
 * @type {EmptyServiceAgent}
 */
export const emptyServiceAgent = new EmptyServiceAgent();

/**
 * @type {EnumServiceAgent}
 */
export const enumServiceAgent = new EnumServiceAgent();